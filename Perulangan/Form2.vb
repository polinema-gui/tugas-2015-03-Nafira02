﻿Public Class Form2
    Dim hasil As String = ""
    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim hasil As String = ""
        Try
            Select Case ComboBox1.Text
                Case "Pyramid"
                    pyramid(Convert.ToInt32(BarisText.Text))
                Case "Hollow Pyramid"
                    hollowPyramid(Convert.ToInt32(BarisText.Text))
                Case "Inverted Pyramid"
                    invertedPyramid(Convert.ToInt32(BarisText.Text))
                Case "Hollow Inverted Pyramid"
                    hollowInvertedPyramid(Convert.ToInt32(BarisText.Text))
                Case Else
                    hasilText.Text = "Anda Belum Memilih Pola"
            End Select
        Catch ex As Exception
            hasilText.Text = "Masukan Bukan Angka"
        End Try
    End Sub

    Private Sub pyramid(batas As Integer)
        Dim batasKolom1 As Integer = batas
        Dim batasKolom2 As Integer = batas
        For baris As Integer = 1 To batas
            For kolom As Integer = 1 To batas * 2 - 1
                If (kolom < batasKolom1 Or kolom > batasKolom2) Then
                    Me.hasil &= "  "
                Else
                    Me.hasil &= "*"
                End If
            Next
            batasKolom1 -= 1
            batasKolom2 += 1
            Me.hasil &= vbCrLf
        Next
        hasilText.Text = hasil
        hasil = ""
    End Sub

    Private Sub hollowPyramid(batas As Integer)
        Dim batasKolom1 As Integer = batas
        Dim batasKolom2 As Integer = batas
        For baris As Integer = 1 To batas
            For kolom As Integer = 1 To batas * 2 - 1
                If (baris < batas) Then
                    If (kolom = batasKolom1 Or kolom = batasKolom2) Then
                        Me.hasil &= "*"
                    Else
                        Me.hasil &= "  "
                    End If
                Else
                    Me.hasil &= "*"
                End If
            Next
            batasKolom1 -= 1
            batasKolom2 += 1
            Me.hasil &= vbCrLf
        Next
        hasilText.Text = hasil
        hasil = ""
    End Sub

    Private Sub invertedPyramid(batas As Integer)
        Dim batasKolom1 As Integer = 0
        Dim batasKolom2 As Integer = batas * 2
        For baris As Integer = 1 To batas
            For kolom As Integer = 1 To batas * 2 - 1
                If (kolom > batasKolom1 And kolom < batasKolom2) Then
                    Me.hasil &= "*"
                Else
                    Me.hasil &= "  "
                End If
            Next
            Me.hasil &= vbCrLf
            batasKolom1 += 1
            batasKolom2 -= 1
        Next
        hasilText.Text = hasil
        Me.hasil = ""
    End Sub

    Private Sub hollowInvertedPyramid(batas As Integer)
        Dim batasKolom1 As Integer = 1
        Dim batasKolom2 As Integer = batas * 2 - 1
        For baris As Integer = 1 To batas
            For kolom As Integer = 1 To batas * 2 - 1
                If (baris = 1) Then
                    Me.hasil &= "*"
                Else
                    If (kolom = batasKolom1 Or kolom = batasKolom2) Then
                        Me.hasil &= "*"
                    Else
                        Me.hasil &= "  "
                    End If
                End If
            Next
            batasKolom1 += 1
            batasKolom2 -= 1
            Me.hasil &= vbCrLf
        Next
        hasilText.Text = hasil
        Me.hasil = ""

    End Sub
End Class