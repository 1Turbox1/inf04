package com.example.inf04;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;
import android.widget.Toast;

import androidx.appcompat.app.AppCompatActivity;

public class MainActivity extends AppCompatActivity {

    private int likes_int = 0;
    private TextView likes_counter;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        likes_counter = findViewById(R.id.likes_count);
        Button like_button = findViewById(R.id.like_button);
        Button dislike_button = findViewById(R.id.delete_button);
        Button save_button = findViewById(R.id.save_button);

        like_button.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                likes_int++;
                update_counter();
            }
        });

        dislike_button.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                if (likes_int > 0) {
                    likes_int--;
                    update_counter();
                }
            }
        });

        save_button.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Toast.makeText(MainActivity.this, "Dane zapisane!", Toast.LENGTH_SHORT).show();
            }
        });
    }

    private void update_counter() {
        likes_counter.setText(likes_int + " polubień");
    }
}
