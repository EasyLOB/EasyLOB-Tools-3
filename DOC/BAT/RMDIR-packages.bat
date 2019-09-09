@ECHO RMDIR "packages" directories
@ECHO Press any key to START or [CTRL][C] to STOP
@PAUSE
FOR /F "tokens=*" %%G IN ('DIR /B /AD /S packages') DO RMDIR /S /Q "%%G"
