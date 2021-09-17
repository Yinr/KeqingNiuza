﻿using System;
using System.IO;
using Microsoft.AppCenter.Crashes;
using static KeqingNiuza.Service.Const;

namespace KeqingNiuza.Service
{
    static class Log
    {
        public static bool EnableLog { get; set; } = true;

        internal static void OutputLog(LogType type, Exception ex)
        {
            Crashes.TrackError(ex);
            if (EnableLog)
            {
                Directory.CreateDirectory(LogPath);
                var fileName = $@"{LogPath}\\log_{DateTime.Now:yyMMdd}.txt";
                var str = $"[{type}][{DateTime.Now:yyMMdd.HHmmss.fff}]\r\n{ex}\r\n\r\n";
                File.AppendAllText(fileName, str);
            }
        }


        internal static void OutputLog(LogType type, string content)
        {
            if (EnableLog)
            {
                Directory.CreateDirectory(LogPath);
                var fileName = $@"{LogPath}\\log_{DateTime.Now:yyMMdd}.txt";
                var str = $"[{type}][{DateTime.Now:yyMMdd.HHmmss.fff}]\r\n{content}\r\n\r\n";
                File.AppendAllText(fileName, str);
            }
        }

        internal static void OutputLog(LogType type, string step, Exception ex)
        {
            Crashes.TrackError(ex);
            if (EnableLog)
            {
                Directory.CreateDirectory(LogPath);
                var fileName = $@"{LogPath}\\log_{DateTime.Now:yyMMdd}.txt";
                var str = $"[{type}][{DateTime.Now:yyMMdd.HHmmss.fff}][{step}]\r\n{ex}\r\n\r\n";
                File.AppendAllText(fileName, str);
            }
        }
    }
}