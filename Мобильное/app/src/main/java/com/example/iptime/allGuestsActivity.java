package com.example.iptime;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

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
import android.widget.ListView;
import android.widget.SimpleAdapter;
import android.widget.Toast;
import android.widget.TwoLineListItem;

import java.util.ArrayList;
import java.util.HashMap;

public class allGuestsActivity extends AppCompatActivity implements View.OnClickListener, AdapterView.OnItemClickListener {

    DBHelperGuests dbHelperGuests;

    ListView guestsList;

    ArrayList<HashMap<String, String>> guestsListItems = new ArrayList<>();
    HashMap<String, String> tempHashMap;

    SimpleAdapter simpleAdapter;

    AutoCompleteTextView autoCompleteTextViewGuestsSearch;

    ArrayList<String> guestsFullName;

    Button buttonSearch;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_all_guests);

        setTitle("Все гости");

        dbHelperGuests = new DBHelperGuests(this);

        // Создание списка гостей
        guestsList = findViewById(R.id.listView_guestsListAnotherScreen);
        getGuestList(null);
        simpleAdapter = new SimpleAdapter(this, guestsListItems,
                android.R.layout.simple_list_item_2, new String[] {"fullName", "contacts"},
                new int[] {android.R.id.text1, android.R.id.text2});
        guestsList.setAdapter(simpleAdapter);

        autoCompleteTextViewGuestsSearch = findViewById(
                R.id.autoCompleteTextView_fullNameAndPhoneSearchGuests
        );
        // Создание списка-подсказки для ввода
        createCoolAutoList();

        buttonSearch = findViewById(R.id.button_searchGuests);
        buttonSearch.setOnClickListener(this);

        guestsList.setOnItemClickListener(this);
    }

    private void getGuestList(String name) {
        SQLiteDatabase database = dbHelperGuests.getWritableDatabase();
        Cursor cursor = database.query(DBHelperGuests.TABLE_GUESTS_FULL_NAME, null,
                null, null, null, null, null);

        if (cursor.moveToFirst()) {
            int fullNameIdIndex = cursor.getColumnIndex(DBHelperGuests.KEY_ID);
            int fullNameIndex = cursor.getColumnIndex(DBHelperGuests.KEY_FULL_NAME);

            do {
                tempHashMap = new HashMap<>();

                String selection = DBHelperGuests.KEY_FULL_NAME_ID + " = ?";
                Cursor tempCursor = database.query(DBHelperGuests.TABLE_GUESTS_CONTACTS,
                        null, selection,
                        new String[] {String.valueOf(cursor.getInt(fullNameIdIndex))},
                        null, null, null);
                int phoneNumIndex = tempCursor.getColumnIndex(DBHelperGuests.KEY_PHONE_NUMBER);
                int emailIndex = tempCursor.getColumnIndex(DBHelperGuests.KEY_EMAIL);
                tempCursor.moveToFirst();
                if (name == null || name.equals(cursor.getString(fullNameIndex))) {
                    tempHashMap.put("fullName", cursor.getString(fullNameIndex));
                    tempHashMap.put("contacts", tempCursor.getString(phoneNumIndex) + "\n" +
                            tempCursor.getString(emailIndex));

                    guestsListItems.add(tempHashMap);
                }
                tempCursor.close();
            } while (cursor.moveToNext());
        }

        cursor.close();
        dbHelperGuests.close();
    }

    private void createCoolAutoList() {
        DBHelperGuests dbHelperGuests = new DBHelperGuests(this);
        SQLiteDatabase database = dbHelperGuests.getWritableDatabase();
        Cursor cursor = database.query(DBHelperGuests.TABLE_GUESTS_FULL_NAME, null,
                null, null, null, null, null);

        guestsFullName = new ArrayList<>();

        if (cursor.moveToFirst()) {
            int fullNameIndex = cursor.getColumnIndex(DBHelperGuests.KEY_FULL_NAME);
            do {
                if (guestsFullName.indexOf(cursor.getString(fullNameIndex)) == -1)
                    guestsFullName.add(cursor.getString(fullNameIndex));
            } while (cursor.moveToNext());
        }

        cursor.close();
        dbHelperGuests.close();

        ArrayAdapter<String> adapter = new ArrayAdapter<>(this,
                android.R.layout.simple_dropdown_item_1line, guestsFullName);
        autoCompleteTextViewGuestsSearch.setAdapter(adapter);
    }

    @Override
    public void onClick(View v) {
        String name = autoCompleteTextViewGuestsSearch.getText().toString();

        if (name.equalsIgnoreCase("")) {
            Toast toast = Toast.makeText(getApplicationContext(),
                    "Поле 'ФИО' пустое!", Toast.LENGTH_SHORT);
            toast.show();
        } else {
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
                autoCompleteTextViewGuestsSearch.setText("");

                tempCursor.close();
                return;
            }
            tempCursor.close();

            guestsListItems.clear();
            getGuestList(name);
            simpleAdapter.notifyDataSetChanged();
            guestsList.invalidateViews();
            guestsList.refreshDrawableState();

            createCoolAutoList();
        }
    }

    // Открытие окна по клику на госте (с необходимой информацией)
    @Override
    public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
        String phoneNumAndEmail = ((TwoLineListItem)view).getText2().getText().toString();
        String phoneNum = phoneNumAndEmail.substring(0, phoneNumAndEmail.indexOf("\n"));

        SQLiteDatabase database = dbHelperGuests.getWritableDatabase();
        String selection = DBHelperGuests.KEY_PHONE_NUMBER + " = ?";
        Cursor cursor = database.query(DBHelperGuests.TABLE_GUESTS_CONTACTS,
                null, selection,
                new String[] {phoneNum},
                null, null, null);
        cursor.moveToFirst();
        int fullNameIdIndex = cursor.getColumnIndex(DBHelperGuests.KEY_FULL_NAME_ID);
        int fullNameId = cursor.getInt(fullNameIdIndex);
        cursor.close();

        Intent intentFullInformationAboutGuest = new Intent(
                this, fullInformationAboutGuestActivity.class
        );
        intentFullInformationAboutGuest.putExtra("fullNameId", String.valueOf(fullNameId));

        startActivity(intentFullInformationAboutGuest);
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        MenuInflater inflater = getMenuInflater();
        inflater.inflate(R.menu.menu_guest_list, menu);

        return true;
    }

    @Override
    public boolean onOptionsItemSelected(@NonNull MenuItem item) {
        guestsListItems.clear();
        getGuestList(null);
        simpleAdapter.notifyDataSetChanged();
        guestsList.invalidateViews();
        guestsList.refreshDrawableState();

        createCoolAutoList();

        return true;
    }
}
