Imports System.ComponentModel
Imports System.IO.Ports

Public Class Form1

    Dim SerialData As String = ""
    Dim TickCounts As Integer = 0
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
        ArdTest.Enabled = False
        SysTicks.Enabled = True
        Call GetSerialPorts()
    End Sub

    Private Sub ArdCon_Click(sender As Object, e As EventArgs) Handles ArdCon.Click
        Try
            If ArdPort.IsOpen = False Then
                ArdPort.PortName = SerialPortsBox.Text
                ArdPort.Open()
                SerialDatBox.AppendText("INFO: Connection Established" + vbCrLf)
                SerialDatBox.ScrollToCaret()
                ArdTest.Enabled = True
            Else
                SerialDatBox.AppendText("INFO: Already Connected" + vbCrLf)
                SerialDatBox.ScrollToCaret()
            End If
        Catch ex As Exception
            SerialDatBox.AppendText("ERROR: Select a valid COM port" + vbCrLf)
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
            End If
        End If
    End Sub

    Private Sub SerialPorts_DropDown(sender As Object, e As EventArgs) Handles SerialPortsBox.DropDown
        Call GetSerialPorts()
    End Sub

    Sub GetSerialPorts()
        SerialPortsBox.Items.Clear()

        For Each sp As String In My.Computer.Ports.SerialPortNames
            SerialPortsBox.Items.Add(sp)
        Next
    End Sub

    Sub ClearAllPorts()
        ArdPort.WriteLine("DIS")
        Threading.Thread.Sleep(100)
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

    Private Sub SerialPorts_TextChanged(sender As Object, e As EventArgs) Handles SerialPortsBox.TextChanged
        If ArdPort.IsOpen = True Then
            ArdPort.Close()
            SerialDatBox.AppendText("INFO: COM closed due to port change" + vbCrLf)
            SerialDatBox.ScrollToCaret()
            ManCtrl.Enabled = False
            ArdTest.Enabled = False
        End If
    End Sub

    Private Sub ArdTest_Click(sender As Object, e As EventArgs) Handles ArdTest.Click
        Dim Response As Boolean = False
        Dim i As Integer = 0

        SysTicks.Enabled = False
        SysStat.Text = "Testing Port"
        If ArdPort.IsOpen = True Then
            SerialDatBox.AppendText("INFO: Testing Connection" + vbCrLf)
            SerialDatBox.ScrollToCaret()
            ArdPort.WriteLine("TESTCON")
            Threading.Thread.Sleep(100)
            SerialData = ReadSerialData()
            If SerialData = ("Arduino connected" & vbCrLf) Then
                SerialDatBox.AppendText("DATA: " + SerialData)
                SerialDatBox.ScrollToCaret()
                Call ClearAllPorts()
                ManCtrl.Enabled = True
            Else
                SerialDatBox.AppendText("WARNING: No response from device. Wrong COM port" + vbCrLf)
                SerialDatBox.ScrollToCaret()
                ArdPort.Close()
                ManCtrl.Enabled = False
                ArdTest.Enabled = False
            End If
        Else
            SerialDatBox.AppendText("WARNING: COM port not open" + vbCrLf)
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
            Threading.Thread.Sleep(100)
        End If
    End Sub

    Private Sub HCH1_Click(sender As Object, e As EventArgs) Handles HCH1.Click
        If LCH1.Checked = True Then
            LCH1.Checked = False
        End If

        If HCH1.Checked = True Then
            ArdPort.WriteLine("H1")
            Threading.Thread.Sleep(100)
        End If
    End Sub

    Private Sub LCH2_Click(sender As Object, e As EventArgs) Handles LCH2.Click
        If HCH2.Checked = True Then
            HCH2.Checked = False
        End If

        If LCH2.Checked = True Then
            ArdPort.WriteLine("L2")
            Threading.Thread.Sleep(100)
        End If
    End Sub

    Private Sub HCH2_Click(sender As Object, e As EventArgs) Handles HCH2.Click
        If LCH2.Checked = True Then
            LCH2.Checked = False
        End If

        If HCH2.Checked = True Then
            ArdPort.WriteLine("H2")
            Threading.Thread.Sleep(100)
        End If
    End Sub

    Private Sub LCH3_Click(sender As Object, e As EventArgs) Handles LCH3.Click
        If HCH3.Checked = True Then
            HCH3.Checked = False
        End If

        If LCH3.Checked = True Then
            ArdPort.WriteLine("L3")
            Threading.Thread.Sleep(100)
        End If
    End Sub

    Private Sub HCH3_Click(sender As Object, e As EventArgs) Handles HCH3.Click
        If LCH3.Checked = True Then
            LCH3.Checked = False
        End If

        If HCH3.Checked = True Then
            ArdPort.WriteLine("H3")
            Threading.Thread.Sleep(100)
        End If
    End Sub

    Private Sub LCH4_Click(sender As Object, e As EventArgs) Handles LCH4.Click
        If HCH4.Checked = True Then
            HCH4.Checked = False
        End If

        If LCH4.Checked = True Then
            ArdPort.WriteLine("L4")
            Threading.Thread.Sleep(100)
        End If
    End Sub

    Private Sub HCH4_Click(sender As Object, e As EventArgs) Handles HCH4.Click
        If LCH4.Checked = True Then
            LCH4.Checked = False
        End If

        If HCH4.Checked = True Then
            ArdPort.WriteLine("H4")
            Threading.Thread.Sleep(100)
        End If
    End Sub

    Private Sub LCH5_Click(sender As Object, e As EventArgs) Handles LCH5.Click
        If HCH5.Checked = True Then
            HCH5.Checked = False
        End If

        If LCH5.Checked = True Then
            ArdPort.WriteLine("L5")
            Threading.Thread.Sleep(100)
        End If
    End Sub

    Private Sub HCH5_Click(sender As Object, e As EventArgs) Handles HCH5.Click
        If LCH5.Checked = True Then
            LCH5.Checked = False
        End If

        If HCH5.Checked = True Then
            ArdPort.WriteLine("H5")
            Threading.Thread.Sleep(100)
        End If
    End Sub

End Class


