package com.example.iptime;

import android.content.Context;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

import androidx.annotation.Nullable;

public class DBHelperGuests extends SQLiteOpenHelper {
    // Данные бд
    private static final int DATABASE_VERSION = 1;
    private static final String DATABASE_NAME = "guestsDb";
    static final String TABLE_GUESTS_FULL_NAME = "guestsFullName";
    static final String TABLE_GUESTS_CONTACTS = "guestsContacts";
    static final String TABLE_GUESTS_DATE = "guestsDate";
    static final String TABLE_GUESTS_PERSONAL_INFORMATION = "guestsPersonalInformation";
    static final String TABLE_GUESTS_COME = "guestsCome";

    static final String KEY_ID = "_id";
    static final String KEY_FULL_NAME = "fullName";
    static final String KEY_FULL_NAME_ID = "fullNameId";
    static final String KEY_PHONE_NUMBER = "phoneNumber";
    static final String KEY_EMAIL = "email";
    static final String KEY_DATE = "date";
    static final String KEY_PERSONAL_INFORMATION = "personalInformation";
    static final String KEY_DATE_ID = "dateId";
    static final String KEY_COME = "come";


    DBHelperGuests(@Nullable Context context) {
        super(context, DATABASE_NAME, null, DATABASE_VERSION);
    }

    // Если базы данных нет - создай ее!
    @Override
    public void onCreate(SQLiteDatabase db) {
        db.execSQL(
                "create table " + TABLE_GUESTS_FULL_NAME + " (" +
                        KEY_ID + " integer primary key autoincrement," +
                        KEY_FULL_NAME + " text" + ");"
        );
        db.execSQL(
                "create table " + TABLE_GUESTS_CONTACTS + " (" +
                        KEY_ID + " integer primary key autoincrement," +
                        KEY_FULL_NAME_ID + " integer," +
                        KEY_PHONE_NUMBER + " text," +
                        KEY_EMAIL + " text" + ");"
        );
        db.execSQL(
                "create table " + TABLE_GUESTS_DATE + " (" +
                        KEY_ID + " integer primary key autoincrement," +
                        KEY_FULL_NAME_ID + " integer," +
                        KEY_DATE + " text" + ");"
        );
        db.execSQL(
                "create table " + TABLE_GUESTS_PERSONAL_INFORMATION + " (" +
                        KEY_ID + " integer primary key autoincrement," +
                        KEY_FULL_NAME_ID + " integer," +
                        KEY_PERSONAL_INFORMATION + " text" + ");"
        );
        db.execSQL(
                "create table " + TABLE_GUESTS_COME + " (" +
                        KEY_ID + " integer primary key autoincrement," +
                        KEY_DATE_ID + " integer," +
                        KEY_COME + " integer" + ");"
        );
    }

    @Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {
        // TODO здесь просто пока заглушка
    }
}
