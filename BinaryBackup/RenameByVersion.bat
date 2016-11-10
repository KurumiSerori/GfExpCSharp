@echo off&setlocal enabledelayedexpansion
set backupDir=F:\Miscellaneous\GfExpCSharp\BinaryBackup
set file=%backupDir%\GfExp.exe
if not exist %file% goto exit
::echo %file%
set wfile=%file:\=\\%
wmic datafile where (name="%wfile%") get version >> version.txt
for /f %%i in ('type version.txt') do (set result=%%i)
::echo %result%
set newfile=GfExp!result!.exe
echo %newfile%
if exist %backupDir%\%newfile% (del %backupDir%\%newfile%&echo "已覆盖同名文件")
ren %file% %newfile%
del version.txt
:exit