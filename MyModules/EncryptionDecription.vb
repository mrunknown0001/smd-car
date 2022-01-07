Imports System.Text
Module EncryptionDecription
    Public Function Encrypt(Encryption As String) As String
        Dim enctext As String = String.Empty
        Dim encode As Byte() = New Byte(Encryption.Length - 1) {}
        encode = Encoding.UTF8.GetBytes(Encryption)
        enctext = Convert.ToBase64String(encode)
        Return enctext
    End Function

    Public Function Decrypt(Decription As String) As String
        Dim decryptext As String = String.Empty
        Dim encodedtext As New UTF8Encoding()
        Dim decode As Decoder = encodedtext.GetDecoder()
        Dim code_byte As Byte() = Convert.FromBase64String(Decription)
        Dim charcount As Integer = decode.GetCharCount(code_byte, 0, code_byte.Length)
        Dim decode_char As Char() = New Char(charcount - 1) {}
        decode.GetChars(code_byte, 0, code_byte.Length, decode_char, 0)
        decryptext = New String(decode_char)
        Return decryptext
    End Function


End Module
