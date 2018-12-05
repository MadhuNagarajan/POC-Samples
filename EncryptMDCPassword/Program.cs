/*******************************************************************************
' Component:    XACES
' Filename:     Program.cs
' Author:       Madhu Nagarajan
' Created:      14-Oct-2017
' Copyright:    Copyright 2017 X-ACES. All Rights Reserved.
'
' Description:
' Service Program File - This is a windows console application to create MDC 
'                        encrypted password and store it in the registry  
'
' Modification History:
' $Log: Program.cs $
'*******************************************************************************/

using System;
using System.Collections.Generic;
using System.Text;
using TripleDESEncryption;
using Microsoft.Win32;

namespace EncryptMDCPassword
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("ERROR: must have one argument");                
                return;
            }

            try
            {
                string strEncryptedString;

                cTripleDESEncryption oEncrypt;

                oEncrypt = new cTripleDESEncryption();

                strEncryptedString = oEncrypt.Encrypt(args[0]);

                RegistryKey rMDCKey = Registry.LocalMachine;

                rMDCKey = rMDCKey.OpenSubKey("SOFTWARE\\XAces\\MDC", true);

                rMDCKey.SetValue("DBPassword", strEncryptedString);

                rMDCKey.Close();

            }
            catch (Exception Ex)
            {
                Console.WriteLine("ERROR: " + Ex.Message);
            }

        }
    }
}
