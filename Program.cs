﻿/*******************************************************************************************
*
*   raylib [core] example - Keyboard input
*
*   This example has been created using raylib 1.0 (www.raylib.com)
*   raylib is licensed under an unmodified zlib/libpng license (View raylib.h for details)
*
*   Copyright (c) 2014 Ramon Santamaria (@raysan5)
*
********************************************************************************************/

using System.Numerics;
using static Raylib_cs.Raylib;
using static Raylib_cs.KeyboardKey;
using static Raylib_cs.Color;

namespace RaylibOne
{
    public class InputKeys
    {
        public static int Main()
        {
            // Initialization
            //--------------------------------------------------------------------------------------
            const int screenWidth = 800;
            const int screenHeight = 450;

            InitWindow(screenWidth, screenHeight, "Cyka Blyat");

            Vector2 ballPosition = new Vector2((float)screenWidth / 2, (float)screenHeight / 2);

            SetTargetFPS(60);       // Set target frames-per-second
            //--------------------------------------------------------------------------------------

            // Main game loop
            while (!WindowShouldClose())    // Detect window close button or ESC key
            {
                // Update
                //----------------------------------------------------------------------------------
                if (IsKeyDown(KEY_RIGHT))
                    ballPosition.X += 10.0f;
                if (IsKeyDown(KEY_LEFT))
                    ballPosition.X -= 10.0f;
                if (IsKeyDown(KEY_UP))
                    ballPosition.Y -= 10.0f;
                if (IsKeyDown(KEY_DOWN))
                    ballPosition.Y += 10.0f;
                //----------------------------------------------------------------------------------

                // Draw
                //----------------------------------------------------------------------------------
                BeginDrawing();
                ClearBackground(RAYWHITE);

                DrawText("move the ball with arrow keys", 10, 10, 20, DARKGRAY);

                DrawCircleV(ballPosition, 25, BLACK);

                EndDrawing();
                //----------------------------------------------------------------------------------
            }

            // De-Initialization
            //--------------------------------------------------------------------------------------
            CloseWindow();        // Close window and OpenGL context
            //--------------------------------------------------------------------------------------

            return 0;
        }
    }
}