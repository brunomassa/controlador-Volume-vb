Imports System.Runtime.InteropServices
Public Class Form1

    Private Const APPCOMMAND_VOLUME_MUTE As Integer = &H80000
    Private Const APPCOMMAND_VOLUME_UP As Integer = &HA0000
    Private Const APPCOMMAND_VOLUME_DOWN As Integer = &H90000
    Private Const WM_APPCOMMAND As Integer = &H319

    <DllImport("user32.dll")> _
    Public Shared Function SendMessageW(ByVal hWnd As IntPtr, _
               ByVal Msg As Integer, ByVal wParam As IntPtr, _
               ByVal lParam As IntPtr) As IntPtr
    End Function


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SendMessageW(Me.Handle, WM_APPCOMMAND, _
                         Me.Handle, New IntPtr(APPCOMMAND_VOLUME_MUTE))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SendMessageW(Me.Handle, WM_APPCOMMAND, _
                         Me.Handle, New IntPtr(APPCOMMAND_VOLUME_UP))
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SendMessageW(Me.Handle, WM_APPCOMMAND, _
                         Me.Handle, New IntPtr(APPCOMMAND_VOLUME_DOWN))
    End Sub
End Class
