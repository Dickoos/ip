package com.example.iptime;

import android.content.ContentValues;
import android.content.Intent;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuInflater;
import android.view.MenuItem;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.AutoCompleteTextView;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.SimpleAdapter;
import android.widget.Toast;
import android.widget.TwoLineListItem;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.HashMap;


public class MainActivity extends AppCompatActivity implements View.OnClickListener, AdapterView.OnItemClickListener {

    DBHelperGuests dbHelperGuests;

    ListView guestsList;

    ArrayList<HashMap<String, String>> guestsListItems = new ArrayList<>();
    HashMap<String, String> tempMap;

    SimpleAdapter simpleAdapter;

    ArrayList<String> guestsFullNameAndPhone;

    AutoCompleteTextView autoCompleteTextViewFullName;
    EditText editTextDate;
    Button buttonSearch;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        setTitle("Гости");

        dbHelperGuests = new DBHelperGuests(this);

        guestsList = findViewById(R.id.listView_guestsList);
        getGuestsListItem(null, null);
        simpleAdapter = new SimpleAdapter(this, guestsListItems,
                android.R.layout.simple_list_item_2, new String[] {"fullName", "datePhoneNumAndId"},
                new int[] {android.R.id.text1, android.R.id.text2});
        guestsList.setAdapter(simpleAdapter);

        createCoolAutoList();

        editTextDate = findViewById(R.id.editText_dateSearch);
        buttonSearch = findViewById(R.id.button_search);
        buttonSearch.setOnClickListener(this);

        guestsList.setOnItemClickListener(this);
    }

    private void getGuestsListItem(String name, String date) { // получаем список гостей
        SQLiteDatabase database = dbHelperGuests.getWritableDatabase();
        Cursor cursor = database.query(DBHelperGuests.TABLE_GUESTS_DATE, null,
                null, null, null, null, null);

        if (cursor.moveToFirst()) {
            int idIndex = cursor.getColumnIndex(DBHelperGuests.KEY_ID);
            int fullNameIdIndex = cursor.getColumnIndex(DBHelperGuests.KEY_FULL_NAME_ID);
            int dateIndex = cursor.getColumnIndex(DBHelperGuests.KEY_DATE);

            do {
                boolean add;

                tempMap = new HashMap<>();

                String selection = DBHelperGuests.KEY_ID + " = ?";
                Cursor tempCursor = database.query(DBHelperGuests.TABLE_GUESTS_FULL_NAME,
                        null, selection,
                        new String[] {String.valueOf(cursor.getInt(fullNameIdIndex))},
                        null, null, null);
                int tempFullNameIndex = tempCursor.getColumnIndex(DBHelperGuests.KEY_FULL_NAME);
                tempCursor.moveToFirst();
                if (name == null || name.equals(tempCursor.getString(tempFullNameIndex))) {
                    tempMap.put("fullName", tempCursor.getString(tempFullNameIndex));
                    add = true;
                } else
                    add = false;

                selection = DBHelperGuests.KEY_FULL_NAME_ID + " = ?";
                tempCursor = database.query(DBHelperGuests.TABLE_GUESTS_CONTACTS,
                        null, selection,
                        new String[] {String.valueOf(cursor.getInt(fullNameIdIndex))},
                        null, null, null);
                int tempPhoneNumIndex = tempCursor.getColumnIndex(DBHelperGuests.KEY_PHONE_NUMBER);
                tempCursor.moveToFirst();

                selection = DBHelperGuests.KEY_DATE_ID + " = ?";
                Cursor tempComeCursor = database.query(DBHelperGuests.TABLE_GUESTS_COME,
                        null, selection,
                        new String[] {
                                String.valueOf(cursor.getInt(idIndex))
                        },
                        null, null, null);
                int tempComeCursorComeIndex = tempComeCursor.getColumnIndex(DBHelperGuests.KEY_COME);
                tempComeCursor.moveToFirst();

                if (add && (date == null || date.equals(cursor.getString(dateIndex)))) {
                    tempMap.put("datePhoneNumAndId", "Дата: " + cursor.getString(dateIndex) +
                            "\nНомер: " + tempCursor.getString(tempPhoneNumIndex) +
                            "\n(" + (tempComeCursor.getInt(tempComeCursorComeIndex) == 0 ? "Не пришёл" : "Пришёл") + ")");
                } else
                    add = false;
                tempCursor.close();
                tempComeCursor.close();

                if (add)
                    guestsListItems.add(tempMap);
            } while (cursor.moveToNext());
        }

        cursor.close();
        dbHelperGuests.close();
    }

    private void createCoolAutoList() { // Список подсказок
        DBHelperGuests dbHelperGuests = new DBHelperGuests(this);
        SQLiteDatabase database = dbHelperGuests.getWritableDatabase();
        Cursor cursor = database.query(DBHelperGuests.TABLE_GUESTS_FULL_NAME, null,
                null, null, null, null, null);

        guestsFullNameAndPhone = new ArrayList<>();

        if (cursor.moveToFirst()) {
            int fullNameIndex = cursor.getColumnIndex(DBHelperGuests.KEY_FULL_NAME);
            do {
                if (guestsFullNameAndPhone.indexOf(cursor.getString(fullNameIndex)) == -1)
                    guestsFullNameAndPhone.add(cursor.getString(fullNameIndex));
            } while (cursor.moveToNext());
        }

        cursor.close();
        dbHelperGuests.close();

        ArrayAdapter<String> adapter = new ArrayAdapter<>(this,
                android.R.layout.simple_dropdown_item_1line, guestsFullNameAndPhone);
        autoCompleteTextViewFullName = findViewById(R.id.autoCompleteTextView_fullNameSearch);
        autoCompleteTextViewFullName.setAdapter(adapter);
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        MenuInflater inflater = getMenuInflater();
        inflater.inflate(R.menu.menu_main, menu);

        return true;
    }

    @Override
    public boolean onOptionsItemSelected(@NonNull MenuItem item) {
        switch (item.getItemId()) {
            case R.id.addGuest:
                Intent intentAddGuest = new Intent(this, addGuestActivity.class);
                startActivity(intentAddGuest);

                return true;
            case R.id.addGuestMeet:
                Intent intentAddGuestMeet = new Intent(this, addGuestMeetActivity.class);
                startActivity(intentAddGuestMeet);

                return true;
            case R.id.updateGuestsData:
                guestsListItems.clear();
                getGuestsListItem(null, null);
                simpleAdapter.notifyDataSetChanged();
                guestsList.invalidateViews();
                guestsList.refreshDrawableState();

                createCoolAutoList();

                return true;
            case R.id.setupGuest:
                Intent intentPass = new Intent(this, passActivity.class);
                startActivity(intentPass);

                return true;
            case R.id.unloadDb:
                // Пока тут заглушка
                Connection connection = null;

                String db_URL = "192.168.1.69:12030";
                String db_DB = "member";
                String db_USER = "pi";
                String db_PASS = "23514317";
                try {
                    Class.forName("org.postgresql.Driver");
                    connection = DriverManager.getConnection(
                            "jdbc:postgresql://" + db_URL + "/" + db_DB,
                            db_USER,
                            db_PASS
                    );
                    connection.setAutoCommit(false);
                } catch (ClassNotFoundException e) {
                    e.printStackTrace();
                } catch (SQLException e) {
                    e.printStackTrace();
                }

                try {
                    connection.close();
                } catch (SQLException e) {
                    e.printStackTrace();
                }

                return true;
            default:
                return super.onOptionsItemSelected(item);
        }
    }

    @Override
    public void onClick(View v) {
        String name = autoCompleteTextViewFullName.getText().toString();
        String date = editTextDate.getText().toString();

        if (name.equalsIgnoreCase("") && date.equalsIgnoreCase("")) {
            Toast toast = Toast.makeText(getApplicationContext(),
                    "Поля 'ФИО' и 'Дата' пустые!", Toast.LENGTH_SHORT);
            toast.show();
        } else if (name.equalsIgnoreCase("")) {
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

            guestsListItems.clear();
            getGuestsListItem(null, date);
            simpleAdapter.notifyDataSetChanged();
            guestsList.invalidateViews();
            guestsList.refreshDrawableState();

            createCoolAutoList();
        } else {
            if (date.equalsIgnoreCase("")) {
                DBHelperGuests dbHelperGuests = new DBHelperGuests(this);
                SQLiteDatabase database = dbHelperGuests.getWritableDatabase();

                String selection = DBHelperGuests.KEY_FULL_NAME + " = ?";
                Cursor tempCursor = database.query(DBHelperGuests.TABLE_GUESTS_FULL_NAME,
                        null, selection,
                        new String[] {name},
                        null, null, null);

                if (tempCursor.getCount() == 0) {
                    Toast toast = Toast.makeText(getApplicationContext(),
                            "Такого имени нет в базе!", Toast.LENGTH_SHORT);
                    toast.show();
                    autoCompleteTextViewFullName.setText("");

                    tempCursor.close();
                    return;
                }
                tempCursor.close();

                guestsListItems.clear();
                getGuestsListItem(name, null);
                simpleAdapter.notifyDataSetChanged();
                guestsList.invalidateViews();
                guestsList.refreshDrawableState();

                createCoolAutoList();
            } else {
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

                DBHelperGuests dbHelperGuests = new DBHelperGuests(this);
                SQLiteDatabase database = dbHelperGuests.getWritableDatabase();

                String selection = DBHelperGuests.KEY_FULL_NAME + " = ?";
                Cursor tempCursor = database.query(DBHelperGuests.TABLE_GUESTS_FULL_NAME,
                        null, selection,
                        new String[] {name},
                        null, null, null);

                if (tempCursor.getCount() == 0) {
                    Toast toast = Toast.makeText(getApplicationContext(),
                            "Такого имени нет в базе!", Toast.LENGTH_SHORT);
                    toast.show();
                    autoCompleteTextViewFullName.setText("");

                    tempCursor.close();
                    return;
                }
                tempCursor.close();

                guestsListItems.clear();
                getGuestsListItem(name, date);
                simpleAdapter.notifyDataSetChanged();
                guestsList.invalidateViews();
                guestsList.refreshDrawableState();

                createCoolAutoList();
            }
        }
    }

    @Override
    public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
        String fullName = ((TwoLineListItem)view).getText1().getText().toString();
        String dateAndNumber = ((TwoLineListItem)view).getText2().getText().toString();

        String number = dateAndNumber.substring(dateAndNumber.lastIndexOf(":") + 2, dateAndNumber.indexOf("(") - 1); // выделение номера
        String date = dateAndNumber.substring(dateAndNumber.indexOf(":") + 2, dateAndNumber.indexOf("\n")); // выделение даты

        SQLiteDatabase database = dbHelperGuests.getWritableDatabase();
        String selection = DBHelperGuests.KEY_PHONE_NUMBER + " = ?";
        Cursor cursor = database.query(DBHelperGuests.TABLE_GUESTS_CONTACTS,
                null, selection,
                new String[] {number},
                null, null, null);
        cursor.moveToFirst();
        int fullNameIdIndex = cursor.getColumnIndex(DBHelperGuests.KEY_FULL_NAME_ID);
        int fullNameId = cursor.getInt(fullNameIdIndex);
        cursor.close();

        selection = DBHelperGuests.KEY_FULL_NAME_ID + " = ? AND " + DBHelperGuests.KEY_DATE + " = ?";
        cursor = database.query(DBHelperGuests.TABLE_GUESTS_DATE,
                null, selection,
                new String[] {String.valueOf(fullNameId), date},
                null, null, null);
        cursor.moveToFirst();
        int dateIdIndex = cursor.getColumnIndex(DBHelperGuests.KEY_ID);
        int dateId = cursor.getInt(dateIdIndex);
        cursor.close();

        selection = DBHelperGuests.KEY_DATE_ID + " = ?";
        cursor = database.query(DBHelperGuests.TABLE_GUESTS_COME,
                null, selection,
                new String[] {String.valueOf(dateId)},
                null, null, null);
        cursor.moveToFirst();
        int comeIndex = cursor.getColumnIndex(DBHelperGuests.KEY_COME);
        int come = cursor.getInt(comeIndex);
        int comeIdIndex = cursor.getColumnIndex(DBHelperGuests.KEY_ID);
        int comeId = cursor.getInt(comeIdIndex);
        cursor.close();

        if (come == 0)
            come = 1;
        else
            come = 0;

        ContentValues contentValues = new ContentValues();
        contentValues.put(DBHelperGuests.KEY_DATE_ID, dateId);
        contentValues.put(DBHelperGuests.KEY_COME, come);
        selection = DBHelperGuests.KEY_ID + " = ?";
        database.update(DBHelperGuests.TABLE_GUESTS_COME, contentValues, selection, new String[] {String.valueOf(comeId)});

        HashMap<String, String> tempHash = new HashMap<>();
        tempHash.put("fullName", fullName);
        tempHash.put("datePhoneNumAndId", "Дата: " + date +
                "\nНомер: " + number +
                "\n(" + (come == 0 ? "Не пришёл" : "Пришёл") + ")");
        guestsListItems.set(position, tempHash);
        simpleAdapter.notifyDataSetChanged();
    }
}
