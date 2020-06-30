package com.example.iptime;

import android.content.ContentValues;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

import androidx.appcompat.app.AppCompatActivity;

public class fullInformationAboutGuestActivity extends AppCompatActivity implements View.OnClickListener {

    DBHelperGuests dbHelperGuests;

    TextView textView_fullNameId;
    EditText editText_FullName;
    EditText editText_phoneNum;
    EditText editText_email;
    EditText editText_personalInformation;

    Button button_save;
    Button button_del;

    String fullNameId;

    SQLiteDatabase database;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_full_information_about_guest);

        fullNameId = getIntent().getStringExtra("fullNameId");

        // При открытии этого окна мы извлекаем все необходимые данные с бд

        dbHelperGuests = new DBHelperGuests(this);
        database = dbHelperGuests.getWritableDatabase();
        String selection = DBHelperGuests.KEY_ID + " = ?";
        Cursor cursor = database.query(DBHelperGuests.TABLE_GUESTS_FULL_NAME,
                null, selection,
                new String[] {fullNameId},
                null, null, null);
        cursor.moveToFirst();
        int fullNameIndex = cursor.getColumnIndex(DBHelperGuests.KEY_FULL_NAME);
        String fullName = cursor.getString(fullNameIndex);
        cursor.close();

        selection = DBHelperGuests.KEY_FULL_NAME_ID + " = ?";
        cursor = database.query(DBHelperGuests.TABLE_GUESTS_CONTACTS,
                null, selection,
                new String[] {fullNameId},
                null, null, null);
        cursor.moveToFirst();
        int phoneNumIndex = cursor.getColumnIndex(DBHelperGuests.KEY_PHONE_NUMBER);
        int emailIndex = cursor.getColumnIndex(DBHelperGuests.KEY_EMAIL);
        String phoneNum = cursor.getString(phoneNumIndex);
        String email = cursor.getString(emailIndex);
        cursor.close();

        cursor = database.query(DBHelperGuests.TABLE_GUESTS_PERSONAL_INFORMATION,
                null, selection,
                new String[] {fullNameId},
                null, null, null);
        cursor.moveToFirst();
        int personalInformationIndex = cursor.getColumnIndex(DBHelperGuests.KEY_PERSONAL_INFORMATION);
        String personalInformation = cursor.getString(personalInformationIndex);
        cursor.close();

        textView_fullNameId = findViewById(R.id.textView_idGuest);
        textView_fullNameId.setText(fullNameId);

        editText_FullName = findViewById(R.id.editText_fullNameGuest);
        editText_FullName.setText(fullName);
        editText_phoneNum = findViewById(R.id.editText_phoneNumGuest);
        editText_phoneNum.setText(phoneNum);
        editText_email = findViewById(R.id.editText_emailGuest);
        editText_email.setText(email);
        editText_personalInformation = findViewById(R.id.editText_personalInformationGuest);
        editText_personalInformation.setText(personalInformation);

        button_save = findViewById(R.id.button_savePersonalInformationAboutGuest);
        button_save.setOnClickListener(this);
        button_del = findViewById(R.id.button_deletePersonalInformationAboutGuest);
        button_del.setOnClickListener(this);
    }

    @Override
    public void onClick(View v) {
        if (v.getId() == R.id.button_deletePersonalInformationAboutGuest) { // Удаление всех упоминаний гостя
            database.delete(
                    DBHelperGuests.TABLE_GUESTS_FULL_NAME,
                    DBHelperGuests.KEY_ID + " = " + fullNameId, null
            );
            database.delete(
                    DBHelperGuests.TABLE_GUESTS_CONTACTS,
                    DBHelperGuests.KEY_FULL_NAME_ID + " = " + fullNameId, null
            );
            database.delete(
                    DBHelperGuests.TABLE_GUESTS_PERSONAL_INFORMATION,
                    DBHelperGuests.KEY_FULL_NAME_ID + " = " + fullNameId, null
            );

            String selection = DBHelperGuests.KEY_FULL_NAME_ID + " = " + fullNameId;
            Cursor cursor = database.query(DBHelperGuests.TABLE_GUESTS_DATE,
                    null, selection,
                    null, null, null, null);

            if (cursor.moveToFirst()) {
                int idIndex = cursor.getColumnIndex(DBHelperGuests.KEY_ID);

                do {
                    database.delete(
                            DBHelperGuests.TABLE_GUESTS_COME,
                            DBHelperGuests.KEY_DATE_ID + " = " + cursor.getInt(idIndex),
                            null
                    );
                } while (cursor.moveToNext());
            }

            cursor.close();

            database.delete(
                    DBHelperGuests.TABLE_GUESTS_DATE,
                    DBHelperGuests.KEY_FULL_NAME_ID + " = " + fullNameId, null
            );

            Toast.makeText(getApplicationContext(),
                    "Запись удалена. Не забудьте обновить списки!",
                    Toast.LENGTH_SHORT).show();

            this.finish();
        } else if (v.getId() == R.id.button_savePersonalInformationAboutGuest) {
            String name = editText_FullName.getText().toString();
            String phoneNum = editText_phoneNum.getText().toString();
            String email = editText_email.getText().toString();
            String personalInformation = editText_personalInformation.getText().toString();

            if (name.equalsIgnoreCase("")) {
                Toast.makeText(getApplicationContext(),
                        "Поле 'ФИО' не может быть пустым!", Toast.LENGTH_SHORT).show();

                return;
            }
            if (phoneNum.equalsIgnoreCase("")) {
                Toast.makeText(getApplicationContext(),
                        "Поле 'Номер телефона' не может быть пустым!",
                        Toast.LENGTH_SHORT).show();

                return;
            } else {
                Cursor cursor = database.query(DBHelperGuests.TABLE_GUESTS_CONTACTS,
                        null, DBHelperGuests.KEY_PHONE_NUMBER + " = " + phoneNum,
                        null, null, null, null);
                cursor.moveToFirst();
                int tempFullNameIdIndex = cursor.getColumnIndex(DBHelperGuests.KEY_FULL_NAME_ID);
                int tempFullNameId = cursor.getInt(tempFullNameIdIndex);
                if (cursor.getCount() > 0 && !String.valueOf(tempFullNameId).equals(fullNameId)) {
                    Toast.makeText(getApplicationContext(),
                            "Такой номер уже есть в базе!", Toast.LENGTH_SHORT).show();

                    editText_phoneNum.setText("");

                    cursor.close();
                    return;
                }
                cursor.close();
            }

            ContentValues contentValues = new ContentValues();
            contentValues.put(DBHelperGuests.KEY_FULL_NAME, name);
            database.update(DBHelperGuests.TABLE_GUESTS_FULL_NAME, contentValues,
                    DBHelperGuests.KEY_ID + " = " + fullNameId, null);
            contentValues.clear();

            contentValues.put(DBHelperGuests.KEY_PHONE_NUMBER, phoneNum);
            contentValues.put(DBHelperGuests.KEY_EMAIL, email);
            database.update(DBHelperGuests.TABLE_GUESTS_CONTACTS, contentValues,
                    DBHelperGuests.KEY_FULL_NAME_ID + " = " + fullNameId, null);
            contentValues.clear();

            contentValues.put(DBHelperGuests.KEY_PERSONAL_INFORMATION, personalInformation);
            database.update(DBHelperGuests.TABLE_GUESTS_PERSONAL_INFORMATION, contentValues,
                    DBHelperGuests.KEY_FULL_NAME_ID + " = " + fullNameId, null);
            contentValues.clear();

            Toast.makeText(getApplicationContext(),
                    "Данные успешно обновлены!", Toast.LENGTH_SHORT).show();
        }
    }
}
