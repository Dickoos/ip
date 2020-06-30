package com.example.iptime;

import android.content.ContentValues;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.os.Bundle;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.AutoCompleteTextView;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import androidx.appcompat.app.AppCompatActivity;

import java.util.ArrayList;

public class addGuestMeetActivity extends AppCompatActivity implements View.OnClickListener {

    ArrayList<String> guestsFullName;

    AutoCompleteTextView autoCompleteTextViewFullNameAndPhone;
    EditText editTextDate;
    Button buttonAdd;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_add_guest_meet);

        setTitle("Добавление гостя на встречу");

        createCoolAutoList();

        editTextDate = findViewById(R.id.editText_addGuestMeetDate);

        buttonAdd = findViewById(R.id.button_addGuestMeet);
        buttonAdd.setOnClickListener(this);
    }

    private void createCoolAutoList() { // Создание списка с подсказками по вводу
        DBHelperGuests dbHelperGuests = new DBHelperGuests(this);
        SQLiteDatabase database = dbHelperGuests.getWritableDatabase();
        Cursor cursor = database.query(DBHelperGuests.TABLE_GUESTS_FULL_NAME, null,
                null, null, null, null, null);

        guestsFullName = new ArrayList<>();

        if (cursor.moveToFirst()) {
            int id = cursor.getColumnIndex(DBHelperGuests.KEY_ID);
            int fullNameIndex = cursor.getColumnIndex(DBHelperGuests.KEY_FULL_NAME);
            do {
                String selection = DBHelperGuests.KEY_FULL_NAME_ID + " = ?";
                Cursor tempCursor = database.query(DBHelperGuests.TABLE_GUESTS_CONTACTS,
                        null, selection,
                        new String[] {String.valueOf(cursor.getInt(id))},
                        null, null, null);
                int tempPhoneNumIndex = tempCursor.getColumnIndex(DBHelperGuests.KEY_PHONE_NUMBER);
                tempCursor.moveToFirst();

                guestsFullName.add(cursor.getString(fullNameIndex) + " (" +
                        tempCursor.getString(tempPhoneNumIndex) + ")");

                tempCursor.close();
            } while (cursor.moveToNext());
        }

        cursor.close();
        dbHelperGuests.close();

        ArrayAdapter<String> adapter = new ArrayAdapter<>(this,
                android.R.layout.simple_dropdown_item_1line, guestsFullName);
        autoCompleteTextViewFullNameAndPhone = findViewById(R.id.autoCompleteTextView_addGuestMeet);
        autoCompleteTextViewFullNameAndPhone.setAdapter(adapter);
    }

    @Override
    public void onClick(View v) {
        String nameAndPhoneNum = autoCompleteTextViewFullNameAndPhone.getText().toString();
        String date = editTextDate.getText().toString();

        if (nameAndPhoneNum.equalsIgnoreCase("")) {
            Toast toast = Toast.makeText(getApplicationContext(),
                    "Поле 'ФИО' не может быть пустым!", Toast.LENGTH_SHORT);
            toast.show();

            return;
        }
        DBHelperGuests dbHelperGuests = new DBHelperGuests(this);
        SQLiteDatabase database = dbHelperGuests.getWritableDatabase();

        String selection = DBHelperGuests.KEY_FULL_NAME + " = ?";
        Cursor tempCursor = database.query(DBHelperGuests.TABLE_GUESTS_FULL_NAME,
                null, selection,
                new String[] {nameAndPhoneNum.substring(0,
                        nameAndPhoneNum.contains("(") ? (nameAndPhoneNum.indexOf("(") - 1) >= 0 ? nameAndPhoneNum.indexOf("(") - 1 : 0 : 0)}, // Правильное взятие номера телефона из строки
                null, null, null);

        if (tempCursor.getCount() == 0) {
            Toast toast = Toast.makeText(getApplicationContext(),
                    "Такого имени нет в базе!", Toast.LENGTH_SHORT);
            toast.show();
            autoCompleteTextViewFullNameAndPhone.setText("");

            tempCursor.close();
            return;
        }
        tempCursor.close();

        if (date.equalsIgnoreCase("")) {
            Toast toast = Toast.makeText(getApplicationContext(),
                    "Поле 'Дата' не может быть пустым!", Toast.LENGTH_SHORT);
            toast.show();

            return;
        }

        String[] dateArr = date.split("-");
        if (dateArr.length != 3) {
            Toast toast = Toast.makeText(getApplicationContext(),
                    "Неправильный формат даты!", Toast.LENGTH_SHORT);
            toast.show();
            editTextDate.setText("");

            return;
        } else if (dateArr[0].length() != 4 || dateArr[1].length() != 2 || dateArr[2].length() != 2) {
            Toast toast = Toast.makeText(getApplicationContext(),
                    "Неправильный формат даты!", Toast.LENGTH_SHORT);
            toast.show();
            editTextDate.setText("");

            return;
        }

        try {
            int tempYear = Integer.parseInt(dateArr[0]);
            int tempMonth = Integer.parseInt(dateArr[1]);
            int tempDay = Integer.parseInt(dateArr[2]);

            if (tempYear < 1 || tempYear > 9999 ||
                    tempMonth < 1 || tempMonth > 12 ||
                    tempDay < 1 || tempDay > 31) {
                Toast toast = Toast.makeText(getApplicationContext(),
                        "Неверно указана дата!", Toast.LENGTH_SHORT);
                toast.show();
                editTextDate.setText("");

                return;
            }
        } catch (NumberFormatException e) {
            Toast toast = Toast.makeText(getApplicationContext(),
                    "Неправильный формат даты!", Toast.LENGTH_SHORT);
            toast.show();
            editTextDate.setText("");

            return;
        }

        selection = DBHelperGuests.KEY_PHONE_NUMBER + " = ?";
        int beginIndexOfBrace = nameAndPhoneNum.contains("(") ? nameAndPhoneNum.indexOf("(") + 1 : 0;
        tempCursor = database.query(DBHelperGuests.TABLE_GUESTS_CONTACTS,
                null, selection,
                new String[] {
                        nameAndPhoneNum.substring(
                                beginIndexOfBrace,
                                nameAndPhoneNum.contains(")") ? nameAndPhoneNum.indexOf(")") : beginIndexOfBrace)
                },
                null, null, null);

        if (tempCursor.getCount() == 0) {
            Toast toast = Toast.makeText(getApplicationContext(),
                    "Неверно указан номер!", Toast.LENGTH_SHORT);
            toast.show();

            autoCompleteTextViewFullNameAndPhone.setText("");

            tempCursor.close();
            return;
        }

        tempCursor.moveToFirst();
        String fullNameId = tempCursor.getString(tempCursor.getColumnIndex(
                DBHelperGuests.KEY_FULL_NAME_ID)
        );

        selection = DBHelperGuests.KEY_FULL_NAME_ID + " = ? AND " +
                DBHelperGuests.KEY_DATE + " = ?";
        tempCursor = database.query(DBHelperGuests.TABLE_GUESTS_DATE,
                null, selection, new String[] {fullNameId, date},
                null, null, null);
        if (tempCursor.getCount() > 0) {
            Toast toast = Toast.makeText(getApplicationContext(),
                    "Этот гость уже записан на эту дату!", Toast.LENGTH_SHORT);
            toast.show();

            editTextDate.setText("");

            tempCursor.close();
            return;
        }
        tempCursor.close();

        ContentValues contentValues = new ContentValues();
        contentValues.put(DBHelperGuests.KEY_FULL_NAME_ID, fullNameId);
        contentValues.put(DBHelperGuests.KEY_DATE, date);
        long dateId = database.insert(DBHelperGuests.TABLE_GUESTS_DATE,
                null, contentValues);
        contentValues.clear();

        contentValues.put(DBHelperGuests.KEY_DATE_ID, dateId);
        contentValues.put(DBHelperGuests.KEY_COME, 0);
        database.insert(DBHelperGuests.TABLE_GUESTS_COME, null, contentValues);
        dbHelperGuests.close();

        Toast toast = Toast.makeText(getApplicationContext(),
                "Гость успешно добавлен на " + date, Toast.LENGTH_SHORT);
        toast.show();

        autoCompleteTextViewFullNameAndPhone.setText("");
        editTextDate.setText("");
    }
}
