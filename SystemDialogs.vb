'=======================================================
'Contains wrapper functions for commonly used MessageBox
'calls.
'=======================================================

Module SystemDialogs

    Sub msgAttention(ByVal prompt As String)
        MessageBox.Show(prompt, APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    Sub msgStop(ByVal prompt As String)
        MessageBox.Show(prompt, APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Sub msgInfo(ByVal prompt As String)
        MessageBox.Show(prompt, APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Module
