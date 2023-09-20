package com.example.ierabiltzailea;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.CheckBox;

public class Bigarrena extends AppCompatActivity {

    private CheckBox ch;
    private Button btnbai;
    private Button btnez;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_bigarrena);

        ch = (CheckBox)findViewById(R.id.checkbox);
        btnbai = (Button)findViewById(R.id.btnBai);
        btnez = (Button)findViewById(R.id.btnEz);

        ch.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View v){
                if(ch.isChecked()){
                    btnbai.setText(R.string.bai_en);
                    btnez.setText(R.string.ez_en);
                }else{
                    btnbai.setText(R.string.bai_eu);
                    btnez.setText(R.string.ez_eu);
                }
            }
        });

    }




}