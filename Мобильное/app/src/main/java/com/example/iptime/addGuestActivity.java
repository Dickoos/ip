package com.example.iptime;

import androidx.appcompat.app.AppCompatActivity;

import android.content.ContentValues;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

public class addGuestActivity extends AppCompatActivity implements View.OnClickListener {

    Button buttonSave;
    EditText editTextFullName, editTextPhoneNum, editTextEmail, editTextPersonalInformation;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_add_guest);

        setTitle("Добавление гостя");

        editTextFullName = findViewById(R.id.editText_fullName);
        editTextPhoneNum = findViewById(R.id.editText_phoneNum);
        editTextEmail = findViewById(R.id.editText_email);
        editTextPersonalInformation = findViewById(R.id.editText_info);

        buttonSave = findViewById(R.id.button_save);
        buttonSave.setOnClickListener(this);
    }

    @Override
    public void onClick(View v) {
        if (v.getId() == R.id.button_save) {
            String fullName = editTextFullName.getText().toString();
            String phoneNum = editTextPhoneNum.getText().toString();
            String email = editTextEmail.getText().toString();
            String personalInformation = editTextPersonalInformation.getText().toString();

            // Проверки на правильность ввода
            if (fullName.equalsIgnoreCase("")) {
                Toast toast = Toast.makeText(getApplicationContext(),
                        "Поле 'ФИО' не может быть пустым!", Toast.LENGTH_SHORT);
                toast.show();

                return;
            }
            if (phoneNum.equalsIgnoreCase("")) {
                Toast toast = Toast.makeText(getApplicationContext(),
                        "Поле 'Номер телефона' не может быть пустым!", Toast.LENGTH_SHORT);
                toast.show();

                return;
            } else {
                DBHelperGuests dbHelperGuests = new DBHelperGuests(this);
                SQLiteDatabase database = dbHelperGuests.getWritableDatabase();

                String selection = DBHelperGuests.KEY_PHONE_NUMBER + " = ?";
                Cursor tempCursor = database.query(DBHelperGuests.TABLE_GUESTS_CONTACTS,
                        null, selection,
                        new String[] {phoneNum},
                        null, null, null);

                if (tempCursor.getCount() > 0) {
                    Toast toast = Toast.makeText(getApplicationContext(),
                            "Такой номер уже есть в базе!", Toast.LENGTH_SHORT);
                    toast.show();
                    editTextPhoneNum.setText("");

                    tempCursor.close();
                    return;
                }

                tempCursor.close();
            }

            DBHelperGuests dbHelperGuests = new DBHelperGuests(this);
            SQLiteDatabase database = dbHelperGuests.getWritableDatabase();

            ContentValues contentValues = new ContentValues();
            contentValues.put(DBHelperGuests.KEY_FULL_NAME, fullName);
            long fullNameId = database.insert(DBHelperGuests.TABLE_GUESTS_FULL_NAME,
                    null, contentValues);
            contentValues.clear();

            contentValues.put(DBHelperGuests.KEY_FULL_NAME_ID, fullNameId);
            contentValues.put(DBHelperGuests.KEY_PHONE_NUMBER, phoneNum);
            contentValues.put(DBHelperGuests.KEY_EMAIL, email);
            database.insert(DBHelperGuests.TABLE_GUESTS_CONTACTS,
                    null, contentValues);
            contentValues.clear();

            contentValues.put(DBHelperGuests.KEY_FULL_NAME_ID, fullNameId);
            contentValues.put(DBHelperGuests.KEY_PERSONAL_INFORMATION, personalInformation);
            database.insert(DBHelperGuests.TABLE_GUESTS_PERSONAL_INFORMATION,
                    null, contentValues);

            dbHelperGuests.close();

            Toast toast = Toast.makeText(getApplicationContext(),
                    "Информация о пользователе добавлена в базу", Toast.LENGTH_SHORT);
            toast.show();

            editTextFullName.setText("");
            editTextPhoneNum.setText("");
            editTextEmail.setText("");
            editTextPersonalInformation.setText("");
        }
    }
}
