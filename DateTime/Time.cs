﻿using System;

public static class TimeFormat
{
    public static string GetReadableTime(int seconds)
    {
        int hh = (seconds / 3600);
        seconds = seconds % 3600;
        if (hh > 99)
        {
            return "none";
        }
        int mm = (seconds / 60);
        seconds = seconds % 60;
        return ($"{hh:00}:{mm:00}:{seconds:00}");

    }
}
/*Write a function, which takes a non-negative integer (seconds) as input and returns the time in a human-readable format (HH:MM:SS)

HH = hours, padded to 2 digits, range: 00 - 99
MM = minutes, padded to 2 digits, range: 00 - 59
SS = seconds, padded to 2 digits, range: 00 - 59
The maximum time never exceeds 359999 (99:59:59)

You can find some examples in the test fixtures.*/