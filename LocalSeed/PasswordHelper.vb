Module PasswordHelper
    ' This is an assistive module consisting of an encrypt and decrypt function for securing passwords and any other sensitive data.

    ' function name: Encrypt
    ' desc: This function hashes any sensitive data to become unreadable.
    ' args (password) Returns String
    Public Function Encrypt(password As String) As String
        Return BCrypt.Net.BCrypt.HashPassword(password)
    End Function

    ' function name: Decrypt
    ' desc: This function uses a key to unscramble any sensitive data to become readable again.
    ' args (password, hash) Returns Boolean
    Public Function Decrypt(password As String, hash As String) As Boolean
        Return BCrypt.Net.BCrypt.Verify(password, hash)
    End Function
End Module
