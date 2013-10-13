Imports System.Media.SoundPlayer
Imports Microsoft.Win32

Public Class Form1
    Dim rootDir As String
    Dim a As new MediaPlayer.MediaPlayer
    Public Sub getInstallPath() Handles Me.Load
        Dim key As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Microsoft Games\Age of Empires\2.0")
        rootDir = key.GetValue("InstallationDirectory")
    End Sub
    Public Sub playTaunt(ByRef source As String)
        a.FileName = rootDir + "\" + source
        a.Play()
        getInstallPath()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        playTaunt(My.Resources._01_Yes)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        playTaunt(My.Resources._02_No)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        playTaunt(My.Resources._03_Food__please)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        playTaunt(My.Resources._04_Wood__please)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        playTaunt(My.Resources._05_Gold__PLease)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        playTaunt(My.Resources._06_Stone__please)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        playTaunt(My.Resources._07_Ahh)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        playTaunt(My.Resources._08_All_hail)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        playTaunt(My.Resources._09_Oooh)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        playTaunt(My.Resources._10_Back_to_Age_1)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        playTaunt(My.Resources._11_Herb_laugh)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        playTaunt(My.Resources._12_Being_rushed)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        playTaunt(My.Resources._13_Blame_your_isp)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        playTaunt(My.Resources._14_Start_the_game)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        playTaunt(My.Resources._15_Don_t_Point_That_Thing)
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        playTaunt(My.Resources._16_Enemy_Sighted)
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        playTaunt(My.Resources._17_It_Is_Good)
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        playTaunt(My.Resources._18_I_Need_a_Monk)
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        playTaunt(My.Resources._19_Long_Time_No_Siege)
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        playTaunt(My.Resources._20_My_granny)
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        playTaunt(My.Resources._21_Nice_Town_I_ll_Take_It)
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        playTaunt(My.Resources._22_Quit_Touchin)
    End Sub


    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        playTaunt(My.Resources._23_Raiding_Party)
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        playTaunt(My.Resources._24_Dadgum)
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        playTaunt(My.Resources._25_Smite_Me)
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        playTaunt(My.Resources._26_The_wonder)
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        playTaunt(My.Resources._27_You_play_2_hours)
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        playTaunt(My.Resources._28_You_Should_See_the_Other_Guy)
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        playTaunt(My.Resources._29_Roggan)
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        playTaunt(My.Resources._30_Wololo)
    End Sub
End Class
