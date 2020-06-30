package com.example.iptime;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

public class passActivity extends AppCompatActivity implements View.OnClickListener {

    EditText editText_pass;
    Button button_checkPass;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_pass);

        editText_pass = findViewById(R.id.editText_pass);
        button_checkPass = findViewById(R.id.button_testPass);
        button_checkPass.setOnClickListener(this);
    }

    @Override
    public void onClick(View v) {
        String pass = "23514317"; // Заглушка с паролем
        if (editText_pass.getText().toString().equals(pass)) {
            Intent intent = new Intent(this, allGuestsActivity.class);
            startActivity(intent);

            this.finish();
        }
    }
}
