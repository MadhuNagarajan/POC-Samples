/*******************************************************************************
' Component:    TripleDESEncryption
' Filename:     TripleDESEncryption.cs
' Author:       Madhu Nagarajan
' Created:      22-May-2016
' Copyright:    Copyright 2017 XAces. All Rights Reserved.
'
' Description:
' Component Implementation File.
'
' Modification History:
' $Log: TripleDESEncryption.cs $

'*******************************************************************************/

using System;
using System.IO;
using System.Text;
using System.Security.Cryptography;
using System.Runtime.InteropServices;

namespace TripleDESEncryption
{
  public interface ITripleDESEncryption                                        //v2.. 
  {
    string Encrypt(string strToEncrypt);
    string Decrypt(string strToDecrypt);
  }                                                                            //..v2 

  [ClassInterface(ClassInterfaceType.AutoDispatch)]                            //v2 
  public class cTripleDESEncryption : ITripleDESEncryption
  {
    //Default pconstructor                                                     //v2.. 
    public cTripleDESEncryption()
    { 
    }                                                                          //..v2 

    // define the triple des provider
    private TripleDESCryptoServiceProvider m_tdesTripleDESProvider =           //v2
                                             new TripleDESCryptoServiceProvider();

    // define the string handler
    private UTF8Encoding m_utf8 = new UTF8Encoding();                          //v2

    // define the local property arrays
    //An array of Random values to be used as the secret key
    private byte[] m_rgbyteKey = {14, 18, 7, 5, 22, 9, 11, 20, 2, 3, 6, 15,    //v2
                                  13, 19, 1, 24, 12, 4, 21, 3, 5, 12,
                                  18, 14};
    //An array of Random values to be used as the IV
    private byte[] m_rgbyteIV = {5, 8, 2, 7, 3, 6, 5, 1};                      //v2

    public string Encrypt(string strToEncrypt)                                 //v2 
    {
      byte[] byteInput = m_utf8.GetBytes(strToEncrypt);
      byte[] byteOutput = Transform(byteInput,
                                    m_tdesTripleDESProvider.CreateEncryptor(m_rgbyteKey,
                                                                            m_rgbyteIV));
      return Convert.ToBase64String(byteOutput);
    }

    public string Decrypt(string strToDecrypt)                                 //v2
    {
      byte[] byteInput = Convert.FromBase64String(strToDecrypt);
      byte[] byteOutput = Transform(byteInput,
                                    m_tdesTripleDESProvider.CreateDecryptor(m_rgbyteKey,
                                                                            m_rgbyteIV));
      return m_utf8.GetString(byteOutput);                                
    }

    private byte[] Transform(byte[] byteInput,                                 //v2
                             ICryptoTransform ictCryptoTransform)
    {
      // create the necessary streams
      MemoryStream memStream = new MemoryStream();
      CryptoStream cryptStream = new CryptoStream(memStream,
                                                  ictCryptoTransform,
                                                  CryptoStreamMode.Write);
      // transform the bytes as requested
      cryptStream.Write(byteInput, 0, byteInput.Length);
      cryptStream.FlushFinalBlock();
      // Read the memory stream and
      // convert it back into byte array
      memStream.Position = 0;
      byte[] byteResult = memStream.ToArray();
      // close and release the streams
      memStream.Close();
      cryptStream.Close();
      // hand back the encrypted buffer
      return byteResult;
    }
  }
}