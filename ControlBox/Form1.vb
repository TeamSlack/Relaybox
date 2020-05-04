Imports System.ComponentModel
Imports System.IO.Ports

Public Class Form1

    Dim SerialData As String = ""
    Dim TickCounts As Integer = 0
    Dim StdDelay As Integer = 100
    Function ReadSerialData() As String
        Dim ReadSerial As String

        Try
            ReadSerial = ArdPort.ReadExisting()
            If ReadSerial = "" Then
                Return ""
            Else
                Return ReadSerial
            End If
        Catch ex As Exception
            SerialDatBox.AppendText("ERROR: Read timeout" + vbCrLf)
            SerialDatBox.ScrollToCaret()
        End Try

    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SysTicks.Enabled = True
        SeqBox.ReadOnly = True
        Symbox.ReadOnly = True
        SerialDatBox.ReadOnly = True
        Call GetSerialPorts()
        Call LoadState()
    End Sub

    Private Sub ArdCon_Click(sender As Object, e As EventArgs) Handles ArdCon.Click
        Try
            If ArdPort.IsOpen = False Then
                ArdPort.PortName = SerialPortsBox.Text
                ArdPort.Open()
                SerialDatBox.AppendText("INFO: Connection Established" + vbCrLf)
                SerialDatBox.Update()
                SerialDatBox.ScrollToCaret()
                ArdTest.Enabled = True
            Else
                SerialDatBox.AppendText("INFO: Already Connected" + vbCrLf)
                SerialDatBox.Update()
                SerialDatBox.ScrollToCaret()
            End If
        Catch ex As Exception
            SerialDatBox.AppendText("ERROR: Select a valid COM port" + vbCrLf)
            SerialDatBox.Update()
            SerialDatBox.ScrollToCaret()
            ManCtrl.Enabled = False
        End Try
    End Sub

    Private Sub SysTicks_Tick(sender As Object, e As EventArgs) Handles SysTicks.Tick

        Select Case TickCounts
            Case 0
                SysStat.Text = "Running."
            Case 1
                SysStat.Text = "Running.."
            Case 2
                SysStat.Text = "Running..."
        End Select

        If TickCounts < 3 Then
            TickCounts += 1
        Else
            TickCounts = 0
        End If

        If ArdPort.IsOpen = True Then
            SerialData = ReadSerialData()
            If SerialData IsNot "" Then
                SerialDatBox.AppendText("DATA: " + SerialData)
                SerialDatBox.ScrollToCaret()
                SerialDatBox.Update()
            End If
        End If
    End Sub

    Private Sub SerialPorts_DropDown(sender As Object, e As EventArgs) Handles SerialPortsBox.DropDown
        Call GetSerialPorts()
    End Sub

    Private Sub SerialPorts_TextChanged(sender As Object, e As EventArgs) Handles SerialPortsBox.TextChanged
        If ArdPort.IsOpen = True Then
            ArdPort.Close()
            SerialDatBox.AppendText("INFO: COM closed due to port change" + vbCrLf)
            SerialDatBox.Update()
            SerialDatBox.ScrollToCaret()
            Call LoadState()
        End If
    End Sub

    Private Sub ArdTest_Click(sender As Object, e As EventArgs) Handles ArdTest.Click
        Dim Response As Boolean = False
        Dim i As Integer = 0

        SysTicks.Enabled = False
        SysStat.Text = "Testing Port"
        If ArdPort.IsOpen = True Then
            SerialDatBox.AppendText("INFO: Testing Connection" + vbCrLf)
            SerialDatBox.Update()
            SerialDatBox.ScrollToCaret()
            ArdPort.WriteLine("TESTCON")
            Threading.Thread.Sleep(StdDelay)
            SerialData = ReadSerialData()
            If SerialData = ("Arduino connected" & vbCrLf) Then
                SerialDatBox.AppendText("DATA: " + SerialData)
                SerialDatBox.Update()
                SerialDatBox.ScrollToCaret()
                Call EnabledState()
            Else
                SerialDatBox.AppendText("WARNING: No response from device. Wrong COM port" + vbCrLf)
                SerialDatBox.Update()
                SerialDatBox.ScrollToCaret()
                ArdPort.Close()
                Call LoadState()
            End If
        Else
            SerialDatBox.AppendText("WARNING: COM port not open" + vbCrLf)
            SerialDatBox.Update()
            SerialDatBox.ScrollToCaret()
        End If
        SysStat.Text = "Testing Complete"
        SysTicks.Enabled = True
    End Sub

    Private Sub LCH1_Click(sender As Object, e As EventArgs) Handles LCH1.Click
        If HCH1.Checked = True Then
            HCH1.Checked = False
        End If

        If LCH1.Checked = True Then
            ArdPort.WriteLine("L1")
            Threading.Thread.Sleep(StdDelay)
        Else
            ArdPort.WriteLine("L1C")
            Threading.Thread.Sleep(StdDelay)
        End If
    End Sub

    Private Sub HCH1_Click(sender As Object, e As EventArgs) Handles HCH1.Click
        If LCH1.Checked = True Then
            LCH1.Checked = False
        End If

        If HCH1.Checked = True Then
            ArdPort.WriteLine("H1")
            Threading.Thread.Sleep(StdDelay)
        Else
            ArdPort.WriteLine("H1C")
            Threading.Thread.Sleep(StdDelay)
        End If
    End Sub

    Private Sub LCH2_Click(sender As Object, e As EventArgs) Handles LCH2.Click
        If HCH2.Checked = True Then
            HCH2.Checked = False
        End If

        If LCH2.Checked = True Then
            ArdPort.WriteLine("L2")
            Threading.Thread.Sleep(StdDelay)
        Else
            ArdPort.WriteLine("L2C")
            Threading.Thread.Sleep(StdDelay)
        End If
    End Sub

    Private Sub HCH2_Click(sender As Object, e As EventArgs) Handles HCH2.Click
        If LCH2.Checked = True Then
            LCH2.Checked = False
        End If

        If HCH2.Checked = True Then
            ArdPort.WriteLine("H2")
            Threading.Thread.Sleep(StdDelay)
        Else
            ArdPort.WriteLine("H2C")
            Threading.Thread.Sleep(StdDelay)
        End If
    End Sub

    Private Sub LCH3_Click(sender As Object, e As EventArgs) Handles LCH3.Click
        If HCH3.Checked = True Then
            HCH3.Checked = False
        End If

        If LCH3.Checked = True Then
            ArdPort.WriteLine("L3")
            Threading.Thread.Sleep(StdDelay)
        Else
            ArdPort.WriteLine("L3C")
            Threading.Thread.Sleep(StdDelay)
        End If
    End Sub

    Private Sub HCH3_Click(sender As Object, e As EventArgs) Handles HCH3.Click
        If LCH3.Checked = True Then
            LCH3.Checked = False
        End If

        If HCH3.Checked = True Then
            ArdPort.WriteLine("H3")
            Threading.Thread.Sleep(StdDelay)
        Else
            ArdPort.WriteLine("H3C")
            Threading.Thread.Sleep(StdDelay)
        End If
    End Sub

    Private Sub LCH4_Click(sender As Object, e As EventArgs) Handles LCH4.Click
        If HCH4.Checked = True Then
            HCH4.Checked = False
        End If

        If LCH4.Checked = True Then
            ArdPort.WriteLine("L4")
            Threading.Thread.Sleep(StdDelay)
        Else
            ArdPort.WriteLine("L4C")
            Threading.Thread.Sleep(StdDelay)
        End If
    End Sub

    Private Sub HCH4_Click(sender As Object, e As EventArgs) Handles HCH4.Click
        If LCH4.Checked = True Then
            LCH4.Checked = False
        End If

        If HCH4.Checked = True Then
            ArdPort.WriteLine("H4")
            Threading.Thread.Sleep(StdDelay)
        Else
            ArdPort.WriteLine("H4C")
            Threading.Thread.Sleep(StdDelay)
        End If
    End Sub

    Private Sub LCH5_Click(sender As Object, e As EventArgs) Handles LCH5.Click
        If HCH5.Checked = True Then
            HCH5.Checked = False
        End If

        If LCH5.Checked = True Then
            ArdPort.WriteLine("L5")
            Threading.Thread.Sleep(StdDelay)
        Else
            ArdPort.WriteLine("L5C")
            Threading.Thread.Sleep(StdDelay)
        End If
    End Sub

    Private Sub HCH5_Click(sender As Object, e As EventArgs) Handles HCH5.Click
        If LCH5.Checked = True Then
            LCH5.Checked = False
        End If

        If HCH5.Checked = True Then
            ArdPort.WriteLine("H5")
            Threading.Thread.Sleep(StdDelay)
        Else
            ArdPort.WriteLine("H5C")
            Threading.Thread.Sleep(StdDelay)
        End If
    End Sub

    Private Sub FOpen_Click(sender As Object, e As EventArgs) Handles FOpen.Click
        FileDiag.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        If FileDiag.ShowDialog() = DialogResult.OK Then
            FText.Text = FileDiag.FileName
        End If
    End Sub

    Private Sub LoadSeq_Click(sender As Object, e As EventArgs) Handles LoadSeq.Click
        Dim fileReader = My.Computer.FileSystem.OpenTextFileReader(FText.Text)
        Dim CMDout As String = ""
        Do While Not fileReader.EndOfStream
            CMDout = fileReader.ReadLine()
            SeqBox.AppendText(CMDout + vbCrLf)
            Select Case CMDout
                Case "L1"
                    If HCH1.Checked = False Then
                        LCH1.Checked = True
                    Else
                        HCH1.Checked = False
                        LCH1.Checked = True
                    End If
                Case "H1"
                    If LCH1.Checked = False Then
                        HCH1.Checked = True
                    Else
                        LCH1.Checked = False
                        HCH1.Checked = True
                    End If
                Case "L2"
                    If HCH2.Checked = False Then
                        LCH2.Checked = True
                    Else
                        HCH2.Checked = False
                        LCH2.Checked = True
                    End If
                Case "H2"
                    If LCH2.Checked = False Then
                        HCH2.Checked = True
                    Else
                        LCH2.Checked = False
                        HCH2.Checked = True
                    End If
                Case "L3"
                    If HCH3.Checked = False Then
                        LCH3.Checked = True
                    Else
                        HCH3.Checked = False
                        LCH3.Checked = True
                    End If
                Case "H3"
                    If LCH3.Checked = False Then
                        HCH3.Checked = True
                    Else
                        LCH3.Checked = False
                        HCH3.Checked = True
                    End If
                Case "L4"
                    If HCH4.Checked = False Then
                        LCH4.Checked = True
                    Else
                        HCH4.Checked = False
                        LCH4.Checked = True
                    End If
                Case "H4"
                    If LCH4.Checked = False Then
                        HCH4.Checked = True
                    Else
                        LCH4.Checked = False
                        HCH4.Checked = True
                    End If
                Case "L5"
                    If HCH5.Checked = False Then
                        LCH5.Checked = True
                    Else
                        HCH5.Checked = False
                        LCH5.Checked = True
                    End If
                Case "H5"
                    If LCH5.Checked = False Then
                        HCH5.Checked = True
                    Else
                        LCH5.Checked = False
                        HCH5.Checked = True
                    End If
            End Select
        Loop
    End Sub

    Sub GetSerialPorts()
        SerialPortsBox.Items.Clear()

        For Each sp As String In My.Computer.Ports.SerialPortNames
            SerialPortsBox.Items.Add(sp)
        Next
    End Sub

    Sub ClearAllPorts()
        ArdPort.WriteLine("DIS")
        Threading.Thread.Sleep(StdDelay)
        LCH1.Checked = False
        LCH2.Checked = False
        LCH3.Checked = False
        LCH4.Checked = False
        LCH5.Checked = False

        HCH1.Checked = False
        HCH2.Checked = False
        HCH3.Checked = False
        HCH4.Checked = False
        HCH5.Checked = False
    End Sub

    Private Sub StrSeq_Click(sender As Object, e As EventArgs) Handles StrSeq.Click
        Dim currCMD As String = ""
        Dim DatLen As Integer = 0
        Dim i As Integer = 0
        Dim currText As String = ""

        SysTicks.Enabled = True
        DatLen = SeqBox.Lines.Length - 2
        Symbox.Text = ChrW(9654) + vbCrLf
        Symbox.Update()
        'Symbox.AppendText(DatLen)
        For i = 0 To DatLen
            Symbox.Text = Symbox.Text.Insert(0, ChrW(10004) + vbCrLf)
            currCMD = SeqBox.Lines(i)
            ArdPort.WriteLine(currCMD)
            Threading.Thread.Sleep(100)
            SerialData = ReadSerialData()
            If SerialData IsNot "" Then
                SerialDatBox.AppendText("DATA: " + SerialData)
                SerialDatBox.ScrollToCaret()
                SerialDatBox.Update()
            End If
            Symbox.Update()
        Next i

    End Sub

    Private Sub ClearSeq_Click(sender As Object, e As EventArgs) Handles ClearSeq.Click
        Call ClearAllPorts()
        SeqBox.ResetText()
        Symbox.ResetText()
    End Sub

    Sub LoadState()

        ArdTest.Enabled = False
        LoadSeq.Enabled = False
        ManCtrl.Enabled = False
        FOpen.Enabled = False
        FText.Text = ""
        SeqBox.Enabled = False
        SeqBox.ResetText()
        Symbox.Enabled = False
        Symbox.ResetText()
    End Sub

    Sub EnabledState()
        ArdTest.Enabled = True
        LoadSeq.Enabled = True
        ManCtrl.Enabled = True
        FOpen.Enabled = True
        FText.Text = ""
        SeqBox.Enabled = True
        SeqBox.ResetText()
        Symbox.Enabled = True
        Symbox.ResetText()
        Call ClearAllPorts()
    End Sub

End Class

