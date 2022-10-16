POM for Windows

Software for Production and Operations Management
Version 1.41

http://www.prenhall.com/weiss_pomwin

(C) Copyright 1996, 1997 Howard J. Weiss
hweiss@sbm.temple.edu

=================================================================
For general information view the associated HELP file. Also, please note that there is a file on the diskette named INSTALL with information regarding the installation (which in theory was already accomplished if you are reading this file.)

This document contains the changes that have occurred in the software after the information regarding this software was placed in your text. For general information view the associated HELP file.
 
INTERNET UPGRADES

The most recent version of the software is available through the download library that can be accessed from the bottom of

http://www.prenhall.com/weiss_pomwin

The menu option Prentice Hall Web Site will lead you there.

INSTALLATION

Before installing the software make sure that you have no Windows Applications open. This includes innocuous looking applications such as the clock.

To install the software place the diskette in the A: (B:) drive and from the Windows Program Manager select FILE, RUN and type A:SETUP (B:SETUP) in the box and click on OK. This will begin the installation program. For a normal, regular installation simply click on OK to all of the questions asked.

This will install the files in the list below into the directory C:\POMWIN (Win 3.1) or C:\Program Files\POMWIN (Win 95).

NETWORK - INDIVIDUAL CONFIGURATIONS

If you are running on a network then if you execute the program on this diskette named netSETUP you can have a custom configuration for the software. Answer the questions and then
everytime you run DS for Windows be sure that this diskette is in the A: (B:) drive before you start the program.

UPDATES

The latest upgrade to the software is available through the download library at the bottom of 

http://www.prenhall.com/weiss_pomwin


POTENTIAL INSTALLATION PROBLEMS

The software will install properly for 99.9% of the users but for the few users who encounter problems we offer the following suggestions and comments.

If while you are installing you get a message stating that a program is currently in use you may probably respond by pressing ignore. However, write down the name of the program. The installation program will not install  a new version of this program which generally is alright.

There is a file named THREED.VBX that needs to be installed. If you have an old version and get a message that the file is open and can not be installed then this will cause a problem. IN this case, rename your file from the File Manager (maybe THREED.VBY) and then install this software package. It will then write the newer version.

REPORTED PROBLEMS

Video Display Drivers

One or two users have reported a GPF occurring with a message such as device failure T1064.drv. This problem has been uccesfully fixed by installing the VGA driver from the Windows control panel. The cause of this problem is that the driver for the specific display is too old. It is possible to get updated drivers from the producer. For example, see  
www.tridentsys.com or www.opus.com/kits/support on the internet.

Printers

One user reported a problem printing graphs in color. This was fixed by installing a different printer driver.

Microsoft reports in its Knowledge Base (Q101379) that there is a bug in the HPLJ4 printer driver (HPPCL5E.DRV). They suggest using the HPLJIII printer driver (HPPCL5.DRV) Windows 95. One or two users have reported minor problems in Windows 95. Most of these refer to the printing of the screen. 
     
FILE LIST    

     Files installed into C:\POMWIN 
          POMWIN.EXE
          POMWIN.HLP
          POMWIN.LIC
          REGISTER.EXE
          RANDOM.RSL
          RANDOM.HZR
          README.TXT
          SQCDATA.TXT    
          COMMDLG.DLL
          PHWEB.HTM
          NORMAL.EXE
	  NORMAL.HLP		
     Files installed into the WINDOWS SYSTEM directory
          SSDATA2.VBX
          CMDIALOG.VBX
          PICCLIP.VBX
          THREED.VBX
          VBRUN300.DLL

If you formerly had any of these files and they are replaced then they will be placed in the directory C:\POMWIN\BACKUP (Win 3.1) or C:\Program Files\POMWIN\Backup (Win 95). In theory, they will be replaced only if the files on the installation diskette are newer versions.


