Public NotInheritable Class SplashScreen1

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).


    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Set up the dialog text at runtime according to the application's assembly information.  

        'TODO: Customize the application's assembly information in the "Application" pane of the project 
        '  properties dialog (under the "Project" menu).

        'Application title
        If My.Application.Info.Title <> "" Then
            ApplicationTitle.Text = My.Application.Info.Title
        Else
            'If the application title is missing, use the application name, without the extension
            ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If

        'Format the version information using the text set into the Version control at design time as the
        '  formatting string.  This allows for effective localization if desired.
        '  Build and revision information could be included by using the following code and changing the 
        '  Version control's designtime text to "Version {0}.{1:00}.{2}.{3}" or something similar.  See
        '  String.Format() in Help for more information.
        '
        '    Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)

        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)

        'Copyright info
        Copyright.Text = My.Application.Info.Copyright
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Configuração para a tela de Splash Screem do Sistema
        'Timer e ProgressBar
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value += 4
            If ProgressBar1.Value = 10 Then
                lbl_progresso.Text = "Carregando 10%..."
            End If
            If ProgressBar1.Value = 20 Then
                lbl_progresso.Text = "Carregando 20%..."
            End If
            If ProgressBar1.Value = 30 Then
                lbl_progresso.Text = "Carregando 30%..."
            End If
            If ProgressBar1.Value = 40 Then
                lbl_progresso.Text = "Carregando 40%..."
            End If
            If ProgressBar1.Value = 50 Then
                lbl_progresso.Text = "Carregando 50%..."
            End If
            If ProgressBar1.Value = 60 Then
                lbl_progresso.Text = "Carregando 60%..."
            End If
            If ProgressBar1.Value = 70 Then
                lbl_progresso.Text = "Carregando 70%..."
            End If
            If ProgressBar1.Value = 80 Then
                lbl_progresso.Text = "Carregando 80%..."
            End If
            If ProgressBar1.Value = 90 Then
                lbl_progresso.Text = "Carregando 90%..."
            End If
            If ProgressBar1.Value = 100 Then
                lbl_progresso.Text = "Carregando 100%..."

            End If
        Else
            Timer1.Enabled = False
            Form1.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub MainLayoutPanel_Paint(sender As Object, e As PaintEventArgs) Handles MainLayoutPanel.Paint

    End Sub
End Class
