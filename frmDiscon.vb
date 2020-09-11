Option Strict Off
Option Explicit On
Friend Class FrmDiscon
    Inherits System.Windows.Forms.Form
#Region "Windows Form Designer generated code "
    Public Sub New() 'Stack overflow can happen if any of the New routines ends up calling something that assumes the form is functions like UpdateTooltip
        MyBase.New()
        If m_vb6FormDefInstance Is Nothing Then
            If m_InitializingDefInstance Then
                m_vb6FormDefInstance = Me
            Else
                Try
                    'For the start-up form, the first instance created is the default instance.
                    If System.Reflection.Assembly.GetExecutingAssembly.EntryPoint.DeclaringType Is Me.GetType Then
                        m_vb6FormDefInstance = Me
                    End If
                Catch
                End Try
            End If
        End If
        'This call is required by the Windows Form Designer.
        InitializeComponent()
    End Sub
    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
        If Disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Public ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents _ppiece_24 As System.Windows.Forms.PictureBox
    Public WithEvents _ppiece_23 As System.Windows.Forms.PictureBox
    Public WithEvents _ppiece_22 As System.Windows.Forms.PictureBox
    Public WithEvents _ppiece_21 As System.Windows.Forms.PictureBox
    Public WithEvents _ppiece_20 As System.Windows.Forms.PictureBox
    Public WithEvents _ppiece_19 As System.Windows.Forms.PictureBox
    Public WithEvents _ppiece_18 As System.Windows.Forms.PictureBox
    Public WithEvents _ppiece_17 As System.Windows.Forms.PictureBox
    Public WithEvents _ppiece_16 As System.Windows.Forms.PictureBox
    Public WithEvents _ppiece_15 As System.Windows.Forms.PictureBox
    Public WithEvents _ppiece_14 As System.Windows.Forms.PictureBox
    Public WithEvents _ppiece_13 As System.Windows.Forms.PictureBox
    Public WithEvents _ppiece_12 As System.Windows.Forms.PictureBox
    Public WithEvents _ppiece_11 As System.Windows.Forms.PictureBox
    Public WithEvents _ppiece_10 As System.Windows.Forms.PictureBox
    Public WithEvents _ppiece_9 As System.Windows.Forms.PictureBox
    Public WithEvents _ppiece_8 As System.Windows.Forms.PictureBox
    Public WithEvents _ppiece_7 As System.Windows.Forms.PictureBox
    Public WithEvents _ppiece_6 As System.Windows.Forms.PictureBox
    Public WithEvents _ppiece_5 As System.Windows.Forms.PictureBox
    Public WithEvents _ppiece_4 As System.Windows.Forms.PictureBox
    Public WithEvents _ppiece_3 As System.Windows.Forms.PictureBox
    Public WithEvents _ppiece_2 As System.Windows.Forms.PictureBox
    Public WithEvents _ppiece_1 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_96 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_95 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_94 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_93 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_92 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_91 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_90 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_89 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_88 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_87 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_86 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_85 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_84 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_83 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_82 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_81 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_80 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_79 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_78 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_77 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_76 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_75 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_74 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_73 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_72 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_71 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_70 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_69 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_68 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_67 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_66 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_65 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_64 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_63 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_62 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_61 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_60 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_59 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_58 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_57 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_56 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_55 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_54 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_53 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_52 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_51 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_50 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_49 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_48 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_47 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_46 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_45 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_44 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_43 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_42 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_41 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_40 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_39 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_38 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_37 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_36 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_35 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_34 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_33 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_32 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_31 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_30 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_29 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_28 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_27 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_26 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_25 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_24 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_23 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_22 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_21 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_20 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_19 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_18 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_17 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_16 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_15 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_14 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_13 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_12 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_11 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_10 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_9 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_8 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_7 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_6 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_5 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_4 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_3 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_2 As System.Windows.Forms.PictureBox
    Public WithEvents _segment_1 As System.Windows.Forms.PictureBox
    Public WithEvents ppiece As Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray
    Public WithEvents segment As Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray
    Public WithEvents mnuFileNew As System.Windows.Forms.MenuItem
    Public WithEvents mnuFileExit As System.Windows.Forms.MenuItem
    Public WithEvents mnuFile As System.Windows.Forms.MenuItem
    Public WithEvents mnuEditUndo As System.Windows.Forms.MenuItem
    Public WithEvents mnuEdit As System.Windows.Forms.MenuItem
    Public WithEvents mnuHelp As System.Windows.Forms.MenuItem
    Public MainMenu1 As System.Windows.Forms.MainMenu
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    Public WithEvents Dragger As System.Windows.Forms.PictureBox
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel2 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel3 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel4 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel5 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents MnuHelpRules As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHelpAbout As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDiscon))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me._ppiece_6 = New System.Windows.Forms.PictureBox()
        Me._ppiece_5 = New System.Windows.Forms.PictureBox()
        Me._ppiece_4 = New System.Windows.Forms.PictureBox()
        Me._ppiece_3 = New System.Windows.Forms.PictureBox()
        Me._ppiece_2 = New System.Windows.Forms.PictureBox()
        Me._ppiece_1 = New System.Windows.Forms.PictureBox()
        Me.Dragger = New System.Windows.Forms.PictureBox()
        Me._ppiece_24 = New System.Windows.Forms.PictureBox()
        Me._ppiece_23 = New System.Windows.Forms.PictureBox()
        Me._ppiece_22 = New System.Windows.Forms.PictureBox()
        Me._ppiece_21 = New System.Windows.Forms.PictureBox()
        Me._ppiece_20 = New System.Windows.Forms.PictureBox()
        Me._ppiece_19 = New System.Windows.Forms.PictureBox()
        Me._ppiece_18 = New System.Windows.Forms.PictureBox()
        Me._ppiece_17 = New System.Windows.Forms.PictureBox()
        Me._ppiece_16 = New System.Windows.Forms.PictureBox()
        Me._ppiece_15 = New System.Windows.Forms.PictureBox()
        Me._ppiece_14 = New System.Windows.Forms.PictureBox()
        Me._ppiece_13 = New System.Windows.Forms.PictureBox()
        Me._ppiece_12 = New System.Windows.Forms.PictureBox()
        Me._ppiece_11 = New System.Windows.Forms.PictureBox()
        Me._ppiece_10 = New System.Windows.Forms.PictureBox()
        Me._ppiece_9 = New System.Windows.Forms.PictureBox()
        Me._ppiece_8 = New System.Windows.Forms.PictureBox()
        Me._ppiece_7 = New System.Windows.Forms.PictureBox()
        Me._segment_96 = New System.Windows.Forms.PictureBox()
        Me._segment_95 = New System.Windows.Forms.PictureBox()
        Me._segment_94 = New System.Windows.Forms.PictureBox()
        Me._segment_93 = New System.Windows.Forms.PictureBox()
        Me._segment_92 = New System.Windows.Forms.PictureBox()
        Me._segment_91 = New System.Windows.Forms.PictureBox()
        Me._segment_90 = New System.Windows.Forms.PictureBox()
        Me._segment_89 = New System.Windows.Forms.PictureBox()
        Me._segment_88 = New System.Windows.Forms.PictureBox()
        Me._segment_87 = New System.Windows.Forms.PictureBox()
        Me._segment_86 = New System.Windows.Forms.PictureBox()
        Me._segment_85 = New System.Windows.Forms.PictureBox()
        Me._segment_84 = New System.Windows.Forms.PictureBox()
        Me._segment_83 = New System.Windows.Forms.PictureBox()
        Me._segment_82 = New System.Windows.Forms.PictureBox()
        Me._segment_81 = New System.Windows.Forms.PictureBox()
        Me._segment_80 = New System.Windows.Forms.PictureBox()
        Me._segment_79 = New System.Windows.Forms.PictureBox()
        Me._segment_78 = New System.Windows.Forms.PictureBox()
        Me._segment_77 = New System.Windows.Forms.PictureBox()
        Me._segment_76 = New System.Windows.Forms.PictureBox()
        Me._segment_75 = New System.Windows.Forms.PictureBox()
        Me._segment_74 = New System.Windows.Forms.PictureBox()
        Me._segment_73 = New System.Windows.Forms.PictureBox()
        Me._segment_72 = New System.Windows.Forms.PictureBox()
        Me._segment_71 = New System.Windows.Forms.PictureBox()
        Me._segment_70 = New System.Windows.Forms.PictureBox()
        Me._segment_69 = New System.Windows.Forms.PictureBox()
        Me._segment_68 = New System.Windows.Forms.PictureBox()
        Me._segment_67 = New System.Windows.Forms.PictureBox()
        Me._segment_66 = New System.Windows.Forms.PictureBox()
        Me._segment_65 = New System.Windows.Forms.PictureBox()
        Me._segment_64 = New System.Windows.Forms.PictureBox()
        Me._segment_63 = New System.Windows.Forms.PictureBox()
        Me._segment_62 = New System.Windows.Forms.PictureBox()
        Me._segment_61 = New System.Windows.Forms.PictureBox()
        Me._segment_60 = New System.Windows.Forms.PictureBox()
        Me._segment_59 = New System.Windows.Forms.PictureBox()
        Me._segment_58 = New System.Windows.Forms.PictureBox()
        Me._segment_57 = New System.Windows.Forms.PictureBox()
        Me._segment_56 = New System.Windows.Forms.PictureBox()
        Me._segment_55 = New System.Windows.Forms.PictureBox()
        Me._segment_54 = New System.Windows.Forms.PictureBox()
        Me._segment_53 = New System.Windows.Forms.PictureBox()
        Me._segment_52 = New System.Windows.Forms.PictureBox()
        Me._segment_51 = New System.Windows.Forms.PictureBox()
        Me._segment_50 = New System.Windows.Forms.PictureBox()
        Me._segment_49 = New System.Windows.Forms.PictureBox()
        Me._segment_48 = New System.Windows.Forms.PictureBox()
        Me._segment_47 = New System.Windows.Forms.PictureBox()
        Me._segment_46 = New System.Windows.Forms.PictureBox()
        Me._segment_45 = New System.Windows.Forms.PictureBox()
        Me._segment_44 = New System.Windows.Forms.PictureBox()
        Me._segment_43 = New System.Windows.Forms.PictureBox()
        Me._segment_42 = New System.Windows.Forms.PictureBox()
        Me._segment_41 = New System.Windows.Forms.PictureBox()
        Me._segment_40 = New System.Windows.Forms.PictureBox()
        Me._segment_39 = New System.Windows.Forms.PictureBox()
        Me._segment_38 = New System.Windows.Forms.PictureBox()
        Me._segment_37 = New System.Windows.Forms.PictureBox()
        Me._segment_36 = New System.Windows.Forms.PictureBox()
        Me._segment_35 = New System.Windows.Forms.PictureBox()
        Me._segment_34 = New System.Windows.Forms.PictureBox()
        Me._segment_33 = New System.Windows.Forms.PictureBox()
        Me._segment_32 = New System.Windows.Forms.PictureBox()
        Me._segment_31 = New System.Windows.Forms.PictureBox()
        Me._segment_30 = New System.Windows.Forms.PictureBox()
        Me._segment_29 = New System.Windows.Forms.PictureBox()
        Me._segment_28 = New System.Windows.Forms.PictureBox()
        Me._segment_27 = New System.Windows.Forms.PictureBox()
        Me._segment_26 = New System.Windows.Forms.PictureBox()
        Me._segment_25 = New System.Windows.Forms.PictureBox()
        Me._segment_24 = New System.Windows.Forms.PictureBox()
        Me._segment_23 = New System.Windows.Forms.PictureBox()
        Me._segment_22 = New System.Windows.Forms.PictureBox()
        Me._segment_21 = New System.Windows.Forms.PictureBox()
        Me._segment_20 = New System.Windows.Forms.PictureBox()
        Me._segment_19 = New System.Windows.Forms.PictureBox()
        Me._segment_18 = New System.Windows.Forms.PictureBox()
        Me._segment_17 = New System.Windows.Forms.PictureBox()
        Me._segment_16 = New System.Windows.Forms.PictureBox()
        Me._segment_15 = New System.Windows.Forms.PictureBox()
        Me._segment_14 = New System.Windows.Forms.PictureBox()
        Me._segment_13 = New System.Windows.Forms.PictureBox()
        Me._segment_12 = New System.Windows.Forms.PictureBox()
        Me._segment_11 = New System.Windows.Forms.PictureBox()
        Me._segment_10 = New System.Windows.Forms.PictureBox()
        Me._segment_9 = New System.Windows.Forms.PictureBox()
        Me._segment_8 = New System.Windows.Forms.PictureBox()
        Me._segment_7 = New System.Windows.Forms.PictureBox()
        Me._segment_6 = New System.Windows.Forms.PictureBox()
        Me._segment_5 = New System.Windows.Forms.PictureBox()
        Me._segment_4 = New System.Windows.Forms.PictureBox()
        Me._segment_3 = New System.Windows.Forms.PictureBox()
        Me._segment_2 = New System.Windows.Forms.PictureBox()
        Me._segment_1 = New System.Windows.Forms.PictureBox()
        Me.ppiece = New Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray(Me.components)
        Me.segment = New Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray(Me.components)
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.mnuFile = New System.Windows.Forms.MenuItem()
        Me.mnuFileNew = New System.Windows.Forms.MenuItem()
        Me.mnuFileExit = New System.Windows.Forms.MenuItem()
        Me.mnuEdit = New System.Windows.Forms.MenuItem()
        Me.mnuEditUndo = New System.Windows.Forms.MenuItem()
        Me.mnuHelp = New System.Windows.Forms.MenuItem()
        Me.MnuHelpRules = New System.Windows.Forms.MenuItem()
        Me.mnuHelpAbout = New System.Windows.Forms.MenuItem()
        Me.StatusBar1 = New System.Windows.Forms.StatusBar()
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel()
        Me.StatusBarPanel2 = New System.Windows.Forms.StatusBarPanel()
        Me.StatusBarPanel3 = New System.Windows.Forms.StatusBarPanel()
        Me.StatusBarPanel4 = New System.Windows.Forms.StatusBarPanel()
        Me.StatusBarPanel5 = New System.Windows.Forms.StatusBarPanel()
        CType(Me._ppiece_6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._ppiece_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._ppiece_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._ppiece_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._ppiece_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._ppiece_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dragger, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._ppiece_24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._ppiece_23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._ppiece_22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._ppiece_21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._ppiece_20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._ppiece_19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._ppiece_18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._ppiece_17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._ppiece_16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._ppiece_15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._ppiece_14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._ppiece_13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._ppiece_12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._ppiece_11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._ppiece_10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._ppiece_9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._ppiece_8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._ppiece_7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_96, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_95, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_94, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_93, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_92, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_91, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_90, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_89, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_88, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_87, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_86, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_85, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_84, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_83, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_82, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_81, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_80, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_79, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_78, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_77, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_76, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_75, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_74, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_73, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_72, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_71, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_70, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_69, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_68, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_67, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_66, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_65, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_64, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_63, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_62, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_61, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_60, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_59, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_58, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_57, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_56, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_55, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_54, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_53, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_52, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_51, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_50, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_49, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_48, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_47, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_46, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_45, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_44, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_43, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_42, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_40, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_39, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_38, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_37, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_36, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_35, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._segment_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ppiece, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.segment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_ppiece_6
        '
        Me._ppiece_6.BackColor = System.Drawing.Color.Transparent
        Me._ppiece_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._ppiece_6.Image = CType(resources.GetObject("_ppiece_6.Image"), System.Drawing.Image)
        Me.ppiece.SetIndex(Me._ppiece_6, CType(6, Short))
        Me._ppiece_6.Location = New System.Drawing.Point(200, 96)
        Me._ppiece_6.Name = "_ppiece_6"
        Me._ppiece_6.Size = New System.Drawing.Size(30, 30)
        Me._ppiece_6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._ppiece_6.TabIndex = 19
        Me._ppiece_6.TabStop = False
        Me._ppiece_6.Tag = "6"
        Me.ToolTip1.SetToolTip(Me._ppiece_6, "6")
        '
        '_ppiece_5
        '
        Me._ppiece_5.BackColor = System.Drawing.Color.Transparent
        Me._ppiece_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._ppiece_5.Image = CType(resources.GetObject("_ppiece_5.Image"), System.Drawing.Image)
        Me.ppiece.SetIndex(Me._ppiece_5, CType(5, Short))
        Me._ppiece_5.Location = New System.Drawing.Point(168, 96)
        Me._ppiece_5.Name = "_ppiece_5"
        Me._ppiece_5.Size = New System.Drawing.Size(30, 30)
        Me._ppiece_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._ppiece_5.TabIndex = 20
        Me._ppiece_5.TabStop = False
        Me._ppiece_5.Tag = "5"
        Me.ToolTip1.SetToolTip(Me._ppiece_5, "5")
        '
        '_ppiece_4
        '
        Me._ppiece_4.BackColor = System.Drawing.Color.Transparent
        Me._ppiece_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._ppiece_4.Image = CType(resources.GetObject("_ppiece_4.Image"), System.Drawing.Image)
        Me.ppiece.SetIndex(Me._ppiece_4, CType(4, Short))
        Me._ppiece_4.Location = New System.Drawing.Point(136, 96)
        Me._ppiece_4.Name = "_ppiece_4"
        Me._ppiece_4.Size = New System.Drawing.Size(30, 30)
        Me._ppiece_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._ppiece_4.TabIndex = 21
        Me._ppiece_4.TabStop = False
        Me._ppiece_4.Tag = "4"
        Me.ToolTip1.SetToolTip(Me._ppiece_4, "4")
        '
        '_ppiece_3
        '
        Me._ppiece_3.BackColor = System.Drawing.Color.Transparent
        Me._ppiece_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._ppiece_3.Image = CType(resources.GetObject("_ppiece_3.Image"), System.Drawing.Image)
        Me.ppiece.SetIndex(Me._ppiece_3, CType(3, Short))
        Me._ppiece_3.Location = New System.Drawing.Point(104, 96)
        Me._ppiece_3.Name = "_ppiece_3"
        Me._ppiece_3.Size = New System.Drawing.Size(30, 30)
        Me._ppiece_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._ppiece_3.TabIndex = 22
        Me._ppiece_3.TabStop = False
        Me._ppiece_3.Tag = "3"
        Me.ToolTip1.SetToolTip(Me._ppiece_3, "3")
        '
        '_ppiece_2
        '
        Me._ppiece_2.BackColor = System.Drawing.Color.Transparent
        Me._ppiece_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._ppiece_2.Image = CType(resources.GetObject("_ppiece_2.Image"), System.Drawing.Image)
        Me.ppiece.SetIndex(Me._ppiece_2, CType(2, Short))
        Me._ppiece_2.Location = New System.Drawing.Point(72, 96)
        Me._ppiece_2.Name = "_ppiece_2"
        Me._ppiece_2.Size = New System.Drawing.Size(30, 30)
        Me._ppiece_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._ppiece_2.TabIndex = 23
        Me._ppiece_2.TabStop = False
        Me._ppiece_2.Tag = "2"
        Me.ToolTip1.SetToolTip(Me._ppiece_2, "2")
        '
        '_ppiece_1
        '
        Me._ppiece_1.BackColor = System.Drawing.Color.Transparent
        Me._ppiece_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._ppiece_1.Image = CType(resources.GetObject("_ppiece_1.Image"), System.Drawing.Image)
        Me.ppiece.SetIndex(Me._ppiece_1, CType(1, Short))
        Me._ppiece_1.Location = New System.Drawing.Point(40, 96)
        Me._ppiece_1.Name = "_ppiece_1"
        Me._ppiece_1.Size = New System.Drawing.Size(30, 30)
        Me._ppiece_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._ppiece_1.TabIndex = 24
        Me._ppiece_1.TabStop = False
        Me._ppiece_1.Tag = "1"
        Me.ToolTip1.SetToolTip(Me._ppiece_1, "1")
        '
        'Dragger
        '
        Me.Dragger.BackColor = System.Drawing.Color.Transparent
        Me.Dragger.Cursor = System.Windows.Forms.Cursors.Default
        Me.Dragger.Image = CType(resources.GetObject("Dragger.Image"), System.Drawing.Image)
        Me.Dragger.Location = New System.Drawing.Point(0, 48)
        Me.Dragger.Name = "Dragger"
        Me.Dragger.Size = New System.Drawing.Size(30, 30)
        Me.Dragger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Dragger.TabIndex = 121
        Me.Dragger.TabStop = False
        Me.ToolTip1.SetToolTip(Me.Dragger, "Dragger")
        Me.Dragger.Visible = False
        '
        '_ppiece_24
        '
        Me._ppiece_24.BackColor = System.Drawing.Color.Transparent
        Me._ppiece_24.Cursor = System.Windows.Forms.Cursors.Default
        Me._ppiece_24.Image = CType(resources.GetObject("_ppiece_24.Image"), System.Drawing.Image)
        Me.ppiece.SetIndex(Me._ppiece_24, CType(24, Short))
        Me._ppiece_24.Location = New System.Drawing.Point(200, 0)
        Me._ppiece_24.Name = "_ppiece_24"
        Me._ppiece_24.Size = New System.Drawing.Size(30, 30)
        Me._ppiece_24.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._ppiece_24.TabIndex = 1
        Me._ppiece_24.TabStop = False
        Me._ppiece_24.Tag = "24"
        '
        '_ppiece_23
        '
        Me._ppiece_23.BackColor = System.Drawing.Color.Transparent
        Me._ppiece_23.Cursor = System.Windows.Forms.Cursors.Default
        Me._ppiece_23.Image = CType(resources.GetObject("_ppiece_23.Image"), System.Drawing.Image)
        Me.ppiece.SetIndex(Me._ppiece_23, CType(23, Short))
        Me._ppiece_23.Location = New System.Drawing.Point(168, 0)
        Me._ppiece_23.Name = "_ppiece_23"
        Me._ppiece_23.Size = New System.Drawing.Size(30, 30)
        Me._ppiece_23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._ppiece_23.TabIndex = 2
        Me._ppiece_23.TabStop = False
        Me._ppiece_23.Tag = "23"
        '
        '_ppiece_22
        '
        Me._ppiece_22.BackColor = System.Drawing.Color.Transparent
        Me._ppiece_22.Cursor = System.Windows.Forms.Cursors.Default
        Me._ppiece_22.Image = CType(resources.GetObject("_ppiece_22.Image"), System.Drawing.Image)
        Me.ppiece.SetIndex(Me._ppiece_22, CType(22, Short))
        Me._ppiece_22.Location = New System.Drawing.Point(136, 0)
        Me._ppiece_22.Name = "_ppiece_22"
        Me._ppiece_22.Size = New System.Drawing.Size(30, 30)
        Me._ppiece_22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._ppiece_22.TabIndex = 3
        Me._ppiece_22.TabStop = False
        Me._ppiece_22.Tag = "22"
        '
        '_ppiece_21
        '
        Me._ppiece_21.BackColor = System.Drawing.Color.Transparent
        Me._ppiece_21.Cursor = System.Windows.Forms.Cursors.Default
        Me._ppiece_21.Image = CType(resources.GetObject("_ppiece_21.Image"), System.Drawing.Image)
        Me.ppiece.SetIndex(Me._ppiece_21, CType(21, Short))
        Me._ppiece_21.Location = New System.Drawing.Point(104, 0)
        Me._ppiece_21.Name = "_ppiece_21"
        Me._ppiece_21.Size = New System.Drawing.Size(30, 30)
        Me._ppiece_21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._ppiece_21.TabIndex = 4
        Me._ppiece_21.TabStop = False
        Me._ppiece_21.Tag = "21"
        '
        '_ppiece_20
        '
        Me._ppiece_20.BackColor = System.Drawing.Color.Transparent
        Me._ppiece_20.Cursor = System.Windows.Forms.Cursors.Default
        Me._ppiece_20.Image = CType(resources.GetObject("_ppiece_20.Image"), System.Drawing.Image)
        Me.ppiece.SetIndex(Me._ppiece_20, CType(20, Short))
        Me._ppiece_20.Location = New System.Drawing.Point(40, 0)
        Me._ppiece_20.Name = "_ppiece_20"
        Me._ppiece_20.Size = New System.Drawing.Size(30, 30)
        Me._ppiece_20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._ppiece_20.TabIndex = 5
        Me._ppiece_20.TabStop = False
        Me._ppiece_20.Tag = "20"
        '
        '_ppiece_19
        '
        Me._ppiece_19.BackColor = System.Drawing.Color.Transparent
        Me._ppiece_19.Cursor = System.Windows.Forms.Cursors.Default
        Me._ppiece_19.Image = CType(resources.GetObject("_ppiece_19.Image"), System.Drawing.Image)
        Me.ppiece.SetIndex(Me._ppiece_19, CType(19, Short))
        Me._ppiece_19.Location = New System.Drawing.Point(72, 0)
        Me._ppiece_19.Name = "_ppiece_19"
        Me._ppiece_19.Size = New System.Drawing.Size(30, 30)
        Me._ppiece_19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._ppiece_19.TabIndex = 6
        Me._ppiece_19.TabStop = False
        Me._ppiece_19.Tag = "19"
        '
        '_ppiece_18
        '
        Me._ppiece_18.BackColor = System.Drawing.Color.Transparent
        Me._ppiece_18.Cursor = System.Windows.Forms.Cursors.Default
        Me._ppiece_18.Image = CType(resources.GetObject("_ppiece_18.Image"), System.Drawing.Image)
        Me.ppiece.SetIndex(Me._ppiece_18, CType(18, Short))
        Me._ppiece_18.Location = New System.Drawing.Point(200, 32)
        Me._ppiece_18.Name = "_ppiece_18"
        Me._ppiece_18.Size = New System.Drawing.Size(30, 30)
        Me._ppiece_18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._ppiece_18.TabIndex = 7
        Me._ppiece_18.TabStop = False
        Me._ppiece_18.Tag = "18"
        '
        '_ppiece_17
        '
        Me._ppiece_17.BackColor = System.Drawing.Color.Transparent
        Me._ppiece_17.Cursor = System.Windows.Forms.Cursors.Default
        Me._ppiece_17.Image = CType(resources.GetObject("_ppiece_17.Image"), System.Drawing.Image)
        Me.ppiece.SetIndex(Me._ppiece_17, CType(17, Short))
        Me._ppiece_17.Location = New System.Drawing.Point(168, 32)
        Me._ppiece_17.Name = "_ppiece_17"
        Me._ppiece_17.Size = New System.Drawing.Size(30, 30)
        Me._ppiece_17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._ppiece_17.TabIndex = 8
        Me._ppiece_17.TabStop = False
        Me._ppiece_17.Tag = "17"
        '
        '_ppiece_16
        '
        Me._ppiece_16.BackColor = System.Drawing.Color.Transparent
        Me._ppiece_16.Cursor = System.Windows.Forms.Cursors.Default
        Me._ppiece_16.Image = CType(resources.GetObject("_ppiece_16.Image"), System.Drawing.Image)
        Me.ppiece.SetIndex(Me._ppiece_16, CType(16, Short))
        Me._ppiece_16.Location = New System.Drawing.Point(136, 32)
        Me._ppiece_16.Name = "_ppiece_16"
        Me._ppiece_16.Size = New System.Drawing.Size(30, 30)
        Me._ppiece_16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._ppiece_16.TabIndex = 9
        Me._ppiece_16.TabStop = False
        Me._ppiece_16.Tag = "16"
        '
        '_ppiece_15
        '
        Me._ppiece_15.BackColor = System.Drawing.Color.Transparent
        Me._ppiece_15.Cursor = System.Windows.Forms.Cursors.Default
        Me._ppiece_15.Image = CType(resources.GetObject("_ppiece_15.Image"), System.Drawing.Image)
        Me.ppiece.SetIndex(Me._ppiece_15, CType(15, Short))
        Me._ppiece_15.Location = New System.Drawing.Point(104, 32)
        Me._ppiece_15.Name = "_ppiece_15"
        Me._ppiece_15.Size = New System.Drawing.Size(30, 30)
        Me._ppiece_15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._ppiece_15.TabIndex = 10
        Me._ppiece_15.TabStop = False
        Me._ppiece_15.Tag = "15"
        '
        '_ppiece_14
        '
        Me._ppiece_14.BackColor = System.Drawing.Color.Transparent
        Me._ppiece_14.Cursor = System.Windows.Forms.Cursors.Default
        Me._ppiece_14.Image = CType(resources.GetObject("_ppiece_14.Image"), System.Drawing.Image)
        Me.ppiece.SetIndex(Me._ppiece_14, CType(14, Short))
        Me._ppiece_14.Location = New System.Drawing.Point(72, 32)
        Me._ppiece_14.Name = "_ppiece_14"
        Me._ppiece_14.Size = New System.Drawing.Size(30, 30)
        Me._ppiece_14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._ppiece_14.TabIndex = 11
        Me._ppiece_14.TabStop = False
        Me._ppiece_14.Tag = "14"
        '
        '_ppiece_13
        '
        Me._ppiece_13.BackColor = System.Drawing.Color.Transparent
        Me._ppiece_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._ppiece_13.Image = CType(resources.GetObject("_ppiece_13.Image"), System.Drawing.Image)
        Me.ppiece.SetIndex(Me._ppiece_13, CType(13, Short))
        Me._ppiece_13.Location = New System.Drawing.Point(40, 32)
        Me._ppiece_13.Name = "_ppiece_13"
        Me._ppiece_13.Size = New System.Drawing.Size(30, 30)
        Me._ppiece_13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._ppiece_13.TabIndex = 12
        Me._ppiece_13.TabStop = False
        Me._ppiece_13.Tag = "13"
        '
        '_ppiece_12
        '
        Me._ppiece_12.BackColor = System.Drawing.Color.Transparent
        Me._ppiece_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._ppiece_12.Image = CType(resources.GetObject("_ppiece_12.Image"), System.Drawing.Image)
        Me.ppiece.SetIndex(Me._ppiece_12, CType(12, Short))
        Me._ppiece_12.Location = New System.Drawing.Point(200, 64)
        Me._ppiece_12.Name = "_ppiece_12"
        Me._ppiece_12.Size = New System.Drawing.Size(30, 30)
        Me._ppiece_12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._ppiece_12.TabIndex = 13
        Me._ppiece_12.TabStop = False
        Me._ppiece_12.Tag = "12"
        '
        '_ppiece_11
        '
        Me._ppiece_11.BackColor = System.Drawing.Color.Transparent
        Me._ppiece_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._ppiece_11.Image = CType(resources.GetObject("_ppiece_11.Image"), System.Drawing.Image)
        Me.ppiece.SetIndex(Me._ppiece_11, CType(11, Short))
        Me._ppiece_11.Location = New System.Drawing.Point(168, 64)
        Me._ppiece_11.Name = "_ppiece_11"
        Me._ppiece_11.Size = New System.Drawing.Size(30, 30)
        Me._ppiece_11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._ppiece_11.TabIndex = 14
        Me._ppiece_11.TabStop = False
        Me._ppiece_11.Tag = "11"
        '
        '_ppiece_10
        '
        Me._ppiece_10.BackColor = System.Drawing.Color.Transparent
        Me._ppiece_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._ppiece_10.Image = CType(resources.GetObject("_ppiece_10.Image"), System.Drawing.Image)
        Me.ppiece.SetIndex(Me._ppiece_10, CType(10, Short))
        Me._ppiece_10.Location = New System.Drawing.Point(136, 64)
        Me._ppiece_10.Name = "_ppiece_10"
        Me._ppiece_10.Size = New System.Drawing.Size(30, 30)
        Me._ppiece_10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._ppiece_10.TabIndex = 15
        Me._ppiece_10.TabStop = False
        Me._ppiece_10.Tag = "10"
        '
        '_ppiece_9
        '
        Me._ppiece_9.BackColor = System.Drawing.Color.Transparent
        Me._ppiece_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._ppiece_9.Image = CType(resources.GetObject("_ppiece_9.Image"), System.Drawing.Image)
        Me.ppiece.SetIndex(Me._ppiece_9, CType(9, Short))
        Me._ppiece_9.Location = New System.Drawing.Point(104, 64)
        Me._ppiece_9.Name = "_ppiece_9"
        Me._ppiece_9.Size = New System.Drawing.Size(30, 30)
        Me._ppiece_9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._ppiece_9.TabIndex = 16
        Me._ppiece_9.TabStop = False
        Me._ppiece_9.Tag = "9"
        '
        '_ppiece_8
        '
        Me._ppiece_8.BackColor = System.Drawing.Color.Transparent
        Me._ppiece_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._ppiece_8.Image = CType(resources.GetObject("_ppiece_8.Image"), System.Drawing.Image)
        Me.ppiece.SetIndex(Me._ppiece_8, CType(8, Short))
        Me._ppiece_8.Location = New System.Drawing.Point(72, 64)
        Me._ppiece_8.Name = "_ppiece_8"
        Me._ppiece_8.Size = New System.Drawing.Size(30, 30)
        Me._ppiece_8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._ppiece_8.TabIndex = 17
        Me._ppiece_8.TabStop = False
        Me._ppiece_8.Tag = "8"
        '
        '_ppiece_7
        '
        Me._ppiece_7.BackColor = System.Drawing.Color.Transparent
        Me._ppiece_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._ppiece_7.Image = CType(resources.GetObject("_ppiece_7.Image"), System.Drawing.Image)
        Me.ppiece.SetIndex(Me._ppiece_7, CType(7, Short))
        Me._ppiece_7.Location = New System.Drawing.Point(40, 64)
        Me._ppiece_7.Name = "_ppiece_7"
        Me._ppiece_7.Size = New System.Drawing.Size(30, 30)
        Me._ppiece_7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._ppiece_7.TabIndex = 18
        Me._ppiece_7.TabStop = False
        Me._ppiece_7.Tag = "7"
        '
        '_segment_96
        '
        Me._segment_96.BackColor = System.Drawing.Color.Transparent
        Me._segment_96.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_96.Image = CType(resources.GetObject("_segment_96.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_96, CType(96, Short))
        Me._segment_96.Location = New System.Drawing.Point(432, 160)
        Me._segment_96.Name = "_segment_96"
        Me._segment_96.Size = New System.Drawing.Size(30, 30)
        Me._segment_96.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_96.TabIndex = 25
        Me._segment_96.TabStop = False
        '
        '_segment_95
        '
        Me._segment_95.BackColor = System.Drawing.Color.Transparent
        Me._segment_95.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_95.Image = CType(resources.GetObject("_segment_95.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_95, CType(95, Short))
        Me._segment_95.Location = New System.Drawing.Point(304, 192)
        Me._segment_95.Name = "_segment_95"
        Me._segment_95.Size = New System.Drawing.Size(30, 30)
        Me._segment_95.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_95.TabIndex = 26
        Me._segment_95.TabStop = False
        '
        '_segment_94
        '
        Me._segment_94.BackColor = System.Drawing.Color.Transparent
        Me._segment_94.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_94.Image = CType(resources.GetObject("_segment_94.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_94, CType(94, Short))
        Me._segment_94.Location = New System.Drawing.Point(240, 96)
        Me._segment_94.Name = "_segment_94"
        Me._segment_94.Size = New System.Drawing.Size(30, 30)
        Me._segment_94.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_94.TabIndex = 27
        Me._segment_94.TabStop = False
        '
        '_segment_93
        '
        Me._segment_93.BackColor = System.Drawing.Color.Transparent
        Me._segment_93.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_93.Image = CType(resources.GetObject("_segment_93.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_93, CType(93, Short))
        Me._segment_93.Location = New System.Drawing.Point(272, 96)
        Me._segment_93.Name = "_segment_93"
        Me._segment_93.Size = New System.Drawing.Size(30, 30)
        Me._segment_93.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_93.TabIndex = 28
        Me._segment_93.TabStop = False
        '
        '_segment_92
        '
        Me._segment_92.BackColor = System.Drawing.Color.Transparent
        Me._segment_92.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_92.Image = CType(resources.GetObject("_segment_92.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_92, CType(92, Short))
        Me._segment_92.Location = New System.Drawing.Point(304, 96)
        Me._segment_92.Name = "_segment_92"
        Me._segment_92.Size = New System.Drawing.Size(30, 30)
        Me._segment_92.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_92.TabIndex = 29
        Me._segment_92.TabStop = False
        '
        '_segment_91
        '
        Me._segment_91.BackColor = System.Drawing.Color.Transparent
        Me._segment_91.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_91.Image = CType(resources.GetObject("_segment_91.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_91, CType(91, Short))
        Me._segment_91.Location = New System.Drawing.Point(336, 96)
        Me._segment_91.Name = "_segment_91"
        Me._segment_91.Size = New System.Drawing.Size(30, 30)
        Me._segment_91.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_91.TabIndex = 30
        Me._segment_91.TabStop = False
        '
        '_segment_90
        '
        Me._segment_90.BackColor = System.Drawing.Color.Transparent
        Me._segment_90.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_90.Image = CType(resources.GetObject("_segment_90.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_90, CType(90, Short))
        Me._segment_90.Location = New System.Drawing.Point(368, 96)
        Me._segment_90.Name = "_segment_90"
        Me._segment_90.Size = New System.Drawing.Size(30, 30)
        Me._segment_90.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_90.TabIndex = 31
        Me._segment_90.TabStop = False
        '
        '_segment_89
        '
        Me._segment_89.BackColor = System.Drawing.Color.Transparent
        Me._segment_89.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_89.Image = CType(resources.GetObject("_segment_89.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_89, CType(89, Short))
        Me._segment_89.Location = New System.Drawing.Point(240, 128)
        Me._segment_89.Name = "_segment_89"
        Me._segment_89.Size = New System.Drawing.Size(30, 30)
        Me._segment_89.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_89.TabIndex = 32
        Me._segment_89.TabStop = False
        '
        '_segment_88
        '
        Me._segment_88.BackColor = System.Drawing.Color.Transparent
        Me._segment_88.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_88.Image = CType(resources.GetObject("_segment_88.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_88, CType(88, Short))
        Me._segment_88.Location = New System.Drawing.Point(272, 128)
        Me._segment_88.Name = "_segment_88"
        Me._segment_88.Size = New System.Drawing.Size(30, 30)
        Me._segment_88.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_88.TabIndex = 33
        Me._segment_88.TabStop = False
        '
        '_segment_87
        '
        Me._segment_87.BackColor = System.Drawing.Color.Transparent
        Me._segment_87.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_87.Image = CType(resources.GetObject("_segment_87.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_87, CType(87, Short))
        Me._segment_87.Location = New System.Drawing.Point(304, 128)
        Me._segment_87.Name = "_segment_87"
        Me._segment_87.Size = New System.Drawing.Size(30, 30)
        Me._segment_87.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_87.TabIndex = 34
        Me._segment_87.TabStop = False
        '
        '_segment_86
        '
        Me._segment_86.BackColor = System.Drawing.Color.Transparent
        Me._segment_86.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_86.Image = CType(resources.GetObject("_segment_86.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_86, CType(86, Short))
        Me._segment_86.Location = New System.Drawing.Point(336, 128)
        Me._segment_86.Name = "_segment_86"
        Me._segment_86.Size = New System.Drawing.Size(30, 30)
        Me._segment_86.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_86.TabIndex = 35
        Me._segment_86.TabStop = False
        '
        '_segment_85
        '
        Me._segment_85.BackColor = System.Drawing.Color.Transparent
        Me._segment_85.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_85.Image = CType(resources.GetObject("_segment_85.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_85, CType(85, Short))
        Me._segment_85.Location = New System.Drawing.Point(368, 128)
        Me._segment_85.Name = "_segment_85"
        Me._segment_85.Size = New System.Drawing.Size(30, 30)
        Me._segment_85.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_85.TabIndex = 36
        Me._segment_85.TabStop = False
        '
        '_segment_84
        '
        Me._segment_84.BackColor = System.Drawing.Color.Transparent
        Me._segment_84.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_84.Image = CType(resources.GetObject("_segment_84.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_84, CType(84, Short))
        Me._segment_84.Location = New System.Drawing.Point(240, 160)
        Me._segment_84.Name = "_segment_84"
        Me._segment_84.Size = New System.Drawing.Size(30, 30)
        Me._segment_84.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_84.TabIndex = 37
        Me._segment_84.TabStop = False
        '
        '_segment_83
        '
        Me._segment_83.BackColor = System.Drawing.Color.Transparent
        Me._segment_83.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_83.Image = CType(resources.GetObject("_segment_83.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_83, CType(83, Short))
        Me._segment_83.Location = New System.Drawing.Point(272, 160)
        Me._segment_83.Name = "_segment_83"
        Me._segment_83.Size = New System.Drawing.Size(30, 30)
        Me._segment_83.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_83.TabIndex = 38
        Me._segment_83.TabStop = False
        '
        '_segment_82
        '
        Me._segment_82.BackColor = System.Drawing.Color.Transparent
        Me._segment_82.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_82.Image = CType(resources.GetObject("_segment_82.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_82, CType(82, Short))
        Me._segment_82.Location = New System.Drawing.Point(304, 160)
        Me._segment_82.Name = "_segment_82"
        Me._segment_82.Size = New System.Drawing.Size(30, 30)
        Me._segment_82.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_82.TabIndex = 39
        Me._segment_82.TabStop = False
        '
        '_segment_81
        '
        Me._segment_81.BackColor = System.Drawing.Color.Transparent
        Me._segment_81.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_81.Image = CType(resources.GetObject("_segment_81.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_81, CType(81, Short))
        Me._segment_81.Location = New System.Drawing.Point(336, 160)
        Me._segment_81.Name = "_segment_81"
        Me._segment_81.Size = New System.Drawing.Size(30, 30)
        Me._segment_81.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_81.TabIndex = 40
        Me._segment_81.TabStop = False
        '
        '_segment_80
        '
        Me._segment_80.BackColor = System.Drawing.Color.Transparent
        Me._segment_80.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_80.Image = CType(resources.GetObject("_segment_80.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_80, CType(80, Short))
        Me._segment_80.Location = New System.Drawing.Point(368, 160)
        Me._segment_80.Name = "_segment_80"
        Me._segment_80.Size = New System.Drawing.Size(30, 30)
        Me._segment_80.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_80.TabIndex = 41
        Me._segment_80.TabStop = False
        '
        '_segment_79
        '
        Me._segment_79.BackColor = System.Drawing.Color.Transparent
        Me._segment_79.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_79.Image = CType(resources.GetObject("_segment_79.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_79, CType(79, Short))
        Me._segment_79.Location = New System.Drawing.Point(400, 160)
        Me._segment_79.Name = "_segment_79"
        Me._segment_79.Size = New System.Drawing.Size(30, 30)
        Me._segment_79.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_79.TabIndex = 42
        Me._segment_79.TabStop = False
        '
        '_segment_78
        '
        Me._segment_78.BackColor = System.Drawing.Color.Transparent
        Me._segment_78.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_78.Image = CType(resources.GetObject("_segment_78.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_78, CType(78, Short))
        Me._segment_78.Location = New System.Drawing.Point(240, 192)
        Me._segment_78.Name = "_segment_78"
        Me._segment_78.Size = New System.Drawing.Size(30, 30)
        Me._segment_78.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_78.TabIndex = 43
        Me._segment_78.TabStop = False
        '
        '_segment_77
        '
        Me._segment_77.BackColor = System.Drawing.Color.Transparent
        Me._segment_77.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_77.Image = CType(resources.GetObject("_segment_77.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_77, CType(77, Short))
        Me._segment_77.Location = New System.Drawing.Point(400, 96)
        Me._segment_77.Name = "_segment_77"
        Me._segment_77.Size = New System.Drawing.Size(30, 30)
        Me._segment_77.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_77.TabIndex = 44
        Me._segment_77.TabStop = False
        '
        '_segment_76
        '
        Me._segment_76.BackColor = System.Drawing.Color.Transparent
        Me._segment_76.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_76.Image = CType(resources.GetObject("_segment_76.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_76, CType(76, Short))
        Me._segment_76.Location = New System.Drawing.Point(432, 96)
        Me._segment_76.Name = "_segment_76"
        Me._segment_76.Size = New System.Drawing.Size(30, 30)
        Me._segment_76.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_76.TabIndex = 45
        Me._segment_76.TabStop = False
        '
        '_segment_75
        '
        Me._segment_75.BackColor = System.Drawing.Color.Transparent
        Me._segment_75.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_75.Image = CType(resources.GetObject("_segment_75.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_75, CType(75, Short))
        Me._segment_75.Location = New System.Drawing.Point(464, 96)
        Me._segment_75.Name = "_segment_75"
        Me._segment_75.Size = New System.Drawing.Size(30, 30)
        Me._segment_75.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_75.TabIndex = 46
        Me._segment_75.TabStop = False
        '
        '_segment_74
        '
        Me._segment_74.BackColor = System.Drawing.Color.Transparent
        Me._segment_74.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_74.Image = CType(resources.GetObject("_segment_74.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_74, CType(74, Short))
        Me._segment_74.Location = New System.Drawing.Point(400, 128)
        Me._segment_74.Name = "_segment_74"
        Me._segment_74.Size = New System.Drawing.Size(30, 30)
        Me._segment_74.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_74.TabIndex = 47
        Me._segment_74.TabStop = False
        '
        '_segment_73
        '
        Me._segment_73.BackColor = System.Drawing.Color.Transparent
        Me._segment_73.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_73.Image = CType(resources.GetObject("_segment_73.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_73, CType(73, Short))
        Me._segment_73.Location = New System.Drawing.Point(432, 128)
        Me._segment_73.Name = "_segment_73"
        Me._segment_73.Size = New System.Drawing.Size(30, 30)
        Me._segment_73.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_73.TabIndex = 48
        Me._segment_73.TabStop = False
        '
        '_segment_72
        '
        Me._segment_72.BackColor = System.Drawing.Color.Transparent
        Me._segment_72.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_72.Image = CType(resources.GetObject("_segment_72.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_72, CType(72, Short))
        Me._segment_72.Location = New System.Drawing.Point(464, 128)
        Me._segment_72.Name = "_segment_72"
        Me._segment_72.Size = New System.Drawing.Size(30, 30)
        Me._segment_72.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_72.TabIndex = 49
        Me._segment_72.TabStop = False
        '
        '_segment_71
        '
        Me._segment_71.BackColor = System.Drawing.Color.Transparent
        Me._segment_71.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_71.Image = CType(resources.GetObject("_segment_71.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_71, CType(71, Short))
        Me._segment_71.Location = New System.Drawing.Point(464, 160)
        Me._segment_71.Name = "_segment_71"
        Me._segment_71.Size = New System.Drawing.Size(30, 30)
        Me._segment_71.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_71.TabIndex = 50
        Me._segment_71.TabStop = False
        '
        '_segment_70
        '
        Me._segment_70.BackColor = System.Drawing.Color.Transparent
        Me._segment_70.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_70.Image = CType(resources.GetObject("_segment_70.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_70, CType(70, Short))
        Me._segment_70.Location = New System.Drawing.Point(272, 192)
        Me._segment_70.Name = "_segment_70"
        Me._segment_70.Size = New System.Drawing.Size(30, 30)
        Me._segment_70.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_70.TabIndex = 51
        Me._segment_70.TabStop = False
        '
        '_segment_69
        '
        Me._segment_69.BackColor = System.Drawing.Color.Transparent
        Me._segment_69.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_69.Image = CType(resources.GetObject("_segment_69.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_69, CType(69, Short))
        Me._segment_69.Location = New System.Drawing.Point(336, 192)
        Me._segment_69.Name = "_segment_69"
        Me._segment_69.Size = New System.Drawing.Size(30, 30)
        Me._segment_69.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_69.TabIndex = 52
        Me._segment_69.TabStop = False
        '
        '_segment_68
        '
        Me._segment_68.BackColor = System.Drawing.Color.Transparent
        Me._segment_68.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_68.Image = CType(resources.GetObject("_segment_68.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_68, CType(68, Short))
        Me._segment_68.Location = New System.Drawing.Point(368, 192)
        Me._segment_68.Name = "_segment_68"
        Me._segment_68.Size = New System.Drawing.Size(30, 30)
        Me._segment_68.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_68.TabIndex = 53
        Me._segment_68.TabStop = False
        '
        '_segment_67
        '
        Me._segment_67.BackColor = System.Drawing.Color.Transparent
        Me._segment_67.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_67.Image = CType(resources.GetObject("_segment_67.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_67, CType(67, Short))
        Me._segment_67.Location = New System.Drawing.Point(400, 192)
        Me._segment_67.Name = "_segment_67"
        Me._segment_67.Size = New System.Drawing.Size(30, 30)
        Me._segment_67.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_67.TabIndex = 54
        Me._segment_67.TabStop = False
        '
        '_segment_66
        '
        Me._segment_66.BackColor = System.Drawing.Color.Transparent
        Me._segment_66.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_66.Image = CType(resources.GetObject("_segment_66.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_66, CType(66, Short))
        Me._segment_66.Location = New System.Drawing.Point(432, 192)
        Me._segment_66.Name = "_segment_66"
        Me._segment_66.Size = New System.Drawing.Size(30, 30)
        Me._segment_66.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_66.TabIndex = 55
        Me._segment_66.TabStop = False
        '
        '_segment_65
        '
        Me._segment_65.BackColor = System.Drawing.Color.Transparent
        Me._segment_65.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_65.Image = CType(resources.GetObject("_segment_65.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_65, CType(65, Short))
        Me._segment_65.Location = New System.Drawing.Point(464, 192)
        Me._segment_65.Name = "_segment_65"
        Me._segment_65.Size = New System.Drawing.Size(30, 30)
        Me._segment_65.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_65.TabIndex = 56
        Me._segment_65.TabStop = False
        '
        '_segment_64
        '
        Me._segment_64.BackColor = System.Drawing.Color.Transparent
        Me._segment_64.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_64.Image = CType(resources.GetObject("_segment_64.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_64, CType(64, Short))
        Me._segment_64.Location = New System.Drawing.Point(200, 128)
        Me._segment_64.Name = "_segment_64"
        Me._segment_64.Size = New System.Drawing.Size(30, 30)
        Me._segment_64.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_64.TabIndex = 57
        Me._segment_64.TabStop = False
        '
        '_segment_63
        '
        Me._segment_63.BackColor = System.Drawing.Color.Transparent
        Me._segment_63.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_63.Image = CType(resources.GetObject("_segment_63.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_63, CType(63, Short))
        Me._segment_63.Location = New System.Drawing.Point(144, 128)
        Me._segment_63.Name = "_segment_63"
        Me._segment_63.Size = New System.Drawing.Size(30, 30)
        Me._segment_63.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_63.TabIndex = 58
        Me._segment_63.TabStop = False
        '
        '_segment_62
        '
        Me._segment_62.BackColor = System.Drawing.Color.Transparent
        Me._segment_62.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_62.Image = CType(resources.GetObject("_segment_62.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_62, CType(62, Short))
        Me._segment_62.Location = New System.Drawing.Point(120, 128)
        Me._segment_62.Name = "_segment_62"
        Me._segment_62.Size = New System.Drawing.Size(30, 30)
        Me._segment_62.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_62.TabIndex = 59
        Me._segment_62.TabStop = False
        '
        '_segment_61
        '
        Me._segment_61.BackColor = System.Drawing.Color.Transparent
        Me._segment_61.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_61.Image = CType(resources.GetObject("_segment_61.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_61, CType(61, Short))
        Me._segment_61.Location = New System.Drawing.Point(88, 128)
        Me._segment_61.Name = "_segment_61"
        Me._segment_61.Size = New System.Drawing.Size(30, 30)
        Me._segment_61.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_61.TabIndex = 60
        Me._segment_61.TabStop = False
        '
        '_segment_60
        '
        Me._segment_60.BackColor = System.Drawing.Color.Transparent
        Me._segment_60.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_60.Image = CType(resources.GetObject("_segment_60.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_60, CType(60, Short))
        Me._segment_60.Location = New System.Drawing.Point(64, 128)
        Me._segment_60.Name = "_segment_60"
        Me._segment_60.Size = New System.Drawing.Size(30, 30)
        Me._segment_60.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_60.TabIndex = 61
        Me._segment_60.TabStop = False
        '
        '_segment_59
        '
        Me._segment_59.BackColor = System.Drawing.Color.Transparent
        Me._segment_59.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_59.Image = CType(resources.GetObject("_segment_59.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_59, CType(59, Short))
        Me._segment_59.Location = New System.Drawing.Point(32, 128)
        Me._segment_59.Name = "_segment_59"
        Me._segment_59.Size = New System.Drawing.Size(30, 30)
        Me._segment_59.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_59.TabIndex = 62
        Me._segment_59.TabStop = False
        '
        '_segment_58
        '
        Me._segment_58.BackColor = System.Drawing.Color.Transparent
        Me._segment_58.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_58.Image = CType(resources.GetObject("_segment_58.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_58, CType(58, Short))
        Me._segment_58.Location = New System.Drawing.Point(8, 128)
        Me._segment_58.Name = "_segment_58"
        Me._segment_58.Size = New System.Drawing.Size(30, 30)
        Me._segment_58.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_58.TabIndex = 63
        Me._segment_58.TabStop = False
        '
        '_segment_57
        '
        Me._segment_57.BackColor = System.Drawing.Color.Transparent
        Me._segment_57.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_57.Image = CType(resources.GetObject("_segment_57.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_57, CType(57, Short))
        Me._segment_57.Location = New System.Drawing.Point(8, 160)
        Me._segment_57.Name = "_segment_57"
        Me._segment_57.Size = New System.Drawing.Size(30, 30)
        Me._segment_57.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_57.TabIndex = 64
        Me._segment_57.TabStop = False
        '
        '_segment_56
        '
        Me._segment_56.BackColor = System.Drawing.Color.Transparent
        Me._segment_56.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_56.Image = CType(resources.GetObject("_segment_56.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_56, CType(56, Short))
        Me._segment_56.Location = New System.Drawing.Point(32, 160)
        Me._segment_56.Name = "_segment_56"
        Me._segment_56.Size = New System.Drawing.Size(30, 30)
        Me._segment_56.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_56.TabIndex = 65
        Me._segment_56.TabStop = False
        '
        '_segment_55
        '
        Me._segment_55.BackColor = System.Drawing.Color.Transparent
        Me._segment_55.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_55.Image = CType(resources.GetObject("_segment_55.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_55, CType(55, Short))
        Me._segment_55.Location = New System.Drawing.Point(64, 160)
        Me._segment_55.Name = "_segment_55"
        Me._segment_55.Size = New System.Drawing.Size(27, 30)
        Me._segment_55.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_55.TabIndex = 66
        Me._segment_55.TabStop = False
        '
        '_segment_54
        '
        Me._segment_54.BackColor = System.Drawing.Color.Transparent
        Me._segment_54.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_54.Image = CType(resources.GetObject("_segment_54.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_54, CType(54, Short))
        Me._segment_54.Location = New System.Drawing.Point(88, 160)
        Me._segment_54.Name = "_segment_54"
        Me._segment_54.Size = New System.Drawing.Size(30, 30)
        Me._segment_54.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_54.TabIndex = 67
        Me._segment_54.TabStop = False
        '
        '_segment_53
        '
        Me._segment_53.BackColor = System.Drawing.Color.Transparent
        Me._segment_53.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_53.Image = CType(resources.GetObject("_segment_53.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_53, CType(53, Short))
        Me._segment_53.Location = New System.Drawing.Point(120, 160)
        Me._segment_53.Name = "_segment_53"
        Me._segment_53.Size = New System.Drawing.Size(30, 30)
        Me._segment_53.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_53.TabIndex = 68
        Me._segment_53.TabStop = False
        '
        '_segment_52
        '
        Me._segment_52.BackColor = System.Drawing.Color.Transparent
        Me._segment_52.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_52.Image = CType(resources.GetObject("_segment_52.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_52, CType(52, Short))
        Me._segment_52.Location = New System.Drawing.Point(144, 160)
        Me._segment_52.Name = "_segment_52"
        Me._segment_52.Size = New System.Drawing.Size(30, 30)
        Me._segment_52.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_52.TabIndex = 69
        Me._segment_52.TabStop = False
        '
        '_segment_51
        '
        Me._segment_51.BackColor = System.Drawing.Color.Transparent
        Me._segment_51.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_51.Image = CType(resources.GetObject("_segment_51.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_51, CType(51, Short))
        Me._segment_51.Location = New System.Drawing.Point(176, 160)
        Me._segment_51.Name = "_segment_51"
        Me._segment_51.Size = New System.Drawing.Size(30, 30)
        Me._segment_51.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_51.TabIndex = 70
        Me._segment_51.TabStop = False
        '
        '_segment_50
        '
        Me._segment_50.BackColor = System.Drawing.Color.Transparent
        Me._segment_50.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_50.Image = CType(resources.GetObject("_segment_50.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_50, CType(50, Short))
        Me._segment_50.Location = New System.Drawing.Point(200, 160)
        Me._segment_50.Name = "_segment_50"
        Me._segment_50.Size = New System.Drawing.Size(30, 30)
        Me._segment_50.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_50.TabIndex = 71
        Me._segment_50.TabStop = False
        '
        '_segment_49
        '
        Me._segment_49.BackColor = System.Drawing.Color.Transparent
        Me._segment_49.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_49.Image = CType(resources.GetObject("_segment_49.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_49, CType(49, Short))
        Me._segment_49.Location = New System.Drawing.Point(8, 192)
        Me._segment_49.Name = "_segment_49"
        Me._segment_49.Size = New System.Drawing.Size(30, 30)
        Me._segment_49.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_49.TabIndex = 72
        Me._segment_49.TabStop = False
        '
        '_segment_48
        '
        Me._segment_48.BackColor = System.Drawing.Color.Transparent
        Me._segment_48.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_48.Image = CType(resources.GetObject("_segment_48.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_48, CType(48, Short))
        Me._segment_48.Location = New System.Drawing.Point(32, 192)
        Me._segment_48.Name = "_segment_48"
        Me._segment_48.Size = New System.Drawing.Size(30, 30)
        Me._segment_48.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_48.TabIndex = 73
        Me._segment_48.TabStop = False
        '
        '_segment_47
        '
        Me._segment_47.BackColor = System.Drawing.Color.Transparent
        Me._segment_47.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_47.Image = CType(resources.GetObject("_segment_47.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_47, CType(47, Short))
        Me._segment_47.Location = New System.Drawing.Point(64, 192)
        Me._segment_47.Name = "_segment_47"
        Me._segment_47.Size = New System.Drawing.Size(30, 30)
        Me._segment_47.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_47.TabIndex = 74
        Me._segment_47.TabStop = False
        '
        '_segment_46
        '
        Me._segment_46.BackColor = System.Drawing.Color.Transparent
        Me._segment_46.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_46.Image = CType(resources.GetObject("_segment_46.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_46, CType(46, Short))
        Me._segment_46.Location = New System.Drawing.Point(200, 192)
        Me._segment_46.Name = "_segment_46"
        Me._segment_46.Size = New System.Drawing.Size(30, 30)
        Me._segment_46.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_46.TabIndex = 75
        Me._segment_46.TabStop = False
        '
        '_segment_45
        '
        Me._segment_45.BackColor = System.Drawing.Color.Transparent
        Me._segment_45.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_45.Image = CType(resources.GetObject("_segment_45.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_45, CType(45, Short))
        Me._segment_45.Location = New System.Drawing.Point(176, 192)
        Me._segment_45.Name = "_segment_45"
        Me._segment_45.Size = New System.Drawing.Size(30, 30)
        Me._segment_45.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_45.TabIndex = 76
        Me._segment_45.TabStop = False
        '
        '_segment_44
        '
        Me._segment_44.BackColor = System.Drawing.Color.Transparent
        Me._segment_44.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_44.Image = CType(resources.GetObject("_segment_44.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_44, CType(44, Short))
        Me._segment_44.Location = New System.Drawing.Point(144, 192)
        Me._segment_44.Name = "_segment_44"
        Me._segment_44.Size = New System.Drawing.Size(30, 30)
        Me._segment_44.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_44.TabIndex = 77
        Me._segment_44.TabStop = False
        '
        '_segment_43
        '
        Me._segment_43.BackColor = System.Drawing.Color.Transparent
        Me._segment_43.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_43.Image = CType(resources.GetObject("_segment_43.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_43, CType(43, Short))
        Me._segment_43.Location = New System.Drawing.Point(120, 192)
        Me._segment_43.Name = "_segment_43"
        Me._segment_43.Size = New System.Drawing.Size(30, 30)
        Me._segment_43.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_43.TabIndex = 78
        Me._segment_43.TabStop = False
        '
        '_segment_42
        '
        Me._segment_42.BackColor = System.Drawing.Color.Transparent
        Me._segment_42.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_42.Image = CType(resources.GetObject("_segment_42.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_42, CType(42, Short))
        Me._segment_42.Location = New System.Drawing.Point(88, 192)
        Me._segment_42.Name = "_segment_42"
        Me._segment_42.Size = New System.Drawing.Size(30, 30)
        Me._segment_42.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_42.TabIndex = 79
        Me._segment_42.TabStop = False
        '
        '_segment_41
        '
        Me._segment_41.BackColor = System.Drawing.Color.Transparent
        Me._segment_41.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_41.Image = CType(resources.GetObject("_segment_41.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_41, CType(41, Short))
        Me._segment_41.Location = New System.Drawing.Point(176, 128)
        Me._segment_41.Name = "_segment_41"
        Me._segment_41.Size = New System.Drawing.Size(30, 30)
        Me._segment_41.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_41.TabIndex = 80
        Me._segment_41.TabStop = False
        '
        '_segment_40
        '
        Me._segment_40.BackColor = System.Drawing.Color.Transparent
        Me._segment_40.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_40.Image = CType(resources.GetObject("_segment_40.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_40, CType(40, Short))
        Me._segment_40.Location = New System.Drawing.Point(8, 216)
        Me._segment_40.Name = "_segment_40"
        Me._segment_40.Size = New System.Drawing.Size(30, 30)
        Me._segment_40.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_40.TabIndex = 81
        Me._segment_40.TabStop = False
        '
        '_segment_39
        '
        Me._segment_39.BackColor = System.Drawing.Color.Transparent
        Me._segment_39.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_39.Image = CType(resources.GetObject("_segment_39.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_39, CType(39, Short))
        Me._segment_39.Location = New System.Drawing.Point(32, 216)
        Me._segment_39.Name = "_segment_39"
        Me._segment_39.Size = New System.Drawing.Size(30, 30)
        Me._segment_39.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_39.TabIndex = 82
        Me._segment_39.TabStop = False
        '
        '_segment_38
        '
        Me._segment_38.BackColor = System.Drawing.Color.Transparent
        Me._segment_38.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_38.Image = CType(resources.GetObject("_segment_38.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_38, CType(38, Short))
        Me._segment_38.Location = New System.Drawing.Point(8, 240)
        Me._segment_38.Name = "_segment_38"
        Me._segment_38.Size = New System.Drawing.Size(30, 30)
        Me._segment_38.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_38.TabIndex = 83
        Me._segment_38.TabStop = False
        '
        '_segment_37
        '
        Me._segment_37.BackColor = System.Drawing.Color.Transparent
        Me._segment_37.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_37.Image = CType(resources.GetObject("_segment_37.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_37, CType(37, Short))
        Me._segment_37.Location = New System.Drawing.Point(32, 240)
        Me._segment_37.Name = "_segment_37"
        Me._segment_37.Size = New System.Drawing.Size(30, 30)
        Me._segment_37.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_37.TabIndex = 84
        Me._segment_37.TabStop = False
        '
        '_segment_36
        '
        Me._segment_36.BackColor = System.Drawing.Color.Transparent
        Me._segment_36.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_36.Image = CType(resources.GetObject("_segment_36.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_36, CType(36, Short))
        Me._segment_36.Location = New System.Drawing.Point(8, 264)
        Me._segment_36.Name = "_segment_36"
        Me._segment_36.Size = New System.Drawing.Size(30, 30)
        Me._segment_36.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_36.TabIndex = 85
        Me._segment_36.TabStop = False
        '
        '_segment_35
        '
        Me._segment_35.BackColor = System.Drawing.Color.Transparent
        Me._segment_35.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_35.Image = CType(resources.GetObject("_segment_35.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_35, CType(35, Short))
        Me._segment_35.Location = New System.Drawing.Point(32, 264)
        Me._segment_35.Name = "_segment_35"
        Me._segment_35.Size = New System.Drawing.Size(30, 30)
        Me._segment_35.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_35.TabIndex = 86
        Me._segment_35.TabStop = False
        '
        '_segment_34
        '
        Me._segment_34.BackColor = System.Drawing.Color.Transparent
        Me._segment_34.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_34.Image = CType(resources.GetObject("_segment_34.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_34, CType(34, Short))
        Me._segment_34.Location = New System.Drawing.Point(64, 216)
        Me._segment_34.Name = "_segment_34"
        Me._segment_34.Size = New System.Drawing.Size(30, 30)
        Me._segment_34.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_34.TabIndex = 87
        Me._segment_34.TabStop = False
        '
        '_segment_33
        '
        Me._segment_33.BackColor = System.Drawing.Color.Transparent
        Me._segment_33.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_33.Image = CType(resources.GetObject("_segment_33.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_33, CType(33, Short))
        Me._segment_33.Location = New System.Drawing.Point(88, 216)
        Me._segment_33.Name = "_segment_33"
        Me._segment_33.Size = New System.Drawing.Size(30, 30)
        Me._segment_33.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_33.TabIndex = 88
        Me._segment_33.TabStop = False
        '
        '_segment_32
        '
        Me._segment_32.BackColor = System.Drawing.Color.Transparent
        Me._segment_32.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_32.Image = CType(resources.GetObject("_segment_32.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_32, CType(32, Short))
        Me._segment_32.Location = New System.Drawing.Point(64, 240)
        Me._segment_32.Name = "_segment_32"
        Me._segment_32.Size = New System.Drawing.Size(30, 30)
        Me._segment_32.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_32.TabIndex = 89
        Me._segment_32.TabStop = False
        '
        '_segment_31
        '
        Me._segment_31.BackColor = System.Drawing.Color.Transparent
        Me._segment_31.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_31.Image = CType(resources.GetObject("_segment_31.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_31, CType(31, Short))
        Me._segment_31.Location = New System.Drawing.Point(88, 240)
        Me._segment_31.Name = "_segment_31"
        Me._segment_31.Size = New System.Drawing.Size(30, 30)
        Me._segment_31.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_31.TabIndex = 90
        Me._segment_31.TabStop = False
        '
        '_segment_30
        '
        Me._segment_30.BackColor = System.Drawing.Color.Transparent
        Me._segment_30.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_30.Image = CType(resources.GetObject("_segment_30.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_30, CType(30, Short))
        Me._segment_30.Location = New System.Drawing.Point(64, 264)
        Me._segment_30.Name = "_segment_30"
        Me._segment_30.Size = New System.Drawing.Size(30, 30)
        Me._segment_30.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_30.TabIndex = 91
        Me._segment_30.TabStop = False
        '
        '_segment_29
        '
        Me._segment_29.BackColor = System.Drawing.Color.Transparent
        Me._segment_29.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_29.Image = CType(resources.GetObject("_segment_29.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_29, CType(29, Short))
        Me._segment_29.Location = New System.Drawing.Point(88, 264)
        Me._segment_29.Name = "_segment_29"
        Me._segment_29.Size = New System.Drawing.Size(30, 30)
        Me._segment_29.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_29.TabIndex = 92
        Me._segment_29.TabStop = False
        '
        '_segment_28
        '
        Me._segment_28.BackColor = System.Drawing.Color.Transparent
        Me._segment_28.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_28.Image = CType(resources.GetObject("_segment_28.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_28, CType(28, Short))
        Me._segment_28.Location = New System.Drawing.Point(176, 264)
        Me._segment_28.Name = "_segment_28"
        Me._segment_28.Size = New System.Drawing.Size(30, 30)
        Me._segment_28.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_28.TabIndex = 93
        Me._segment_28.TabStop = False
        '
        '_segment_27
        '
        Me._segment_27.BackColor = System.Drawing.Color.Transparent
        Me._segment_27.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_27.Image = CType(resources.GetObject("_segment_27.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_27, CType(27, Short))
        Me._segment_27.Location = New System.Drawing.Point(144, 264)
        Me._segment_27.Name = "_segment_27"
        Me._segment_27.Size = New System.Drawing.Size(30, 30)
        Me._segment_27.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_27.TabIndex = 94
        Me._segment_27.TabStop = False
        '
        '_segment_26
        '
        Me._segment_26.BackColor = System.Drawing.Color.Transparent
        Me._segment_26.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_26.Image = CType(resources.GetObject("_segment_26.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_26, CType(26, Short))
        Me._segment_26.Location = New System.Drawing.Point(120, 264)
        Me._segment_26.Name = "_segment_26"
        Me._segment_26.Size = New System.Drawing.Size(30, 30)
        Me._segment_26.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_26.TabIndex = 95
        Me._segment_26.TabStop = False
        '
        '_segment_25
        '
        Me._segment_25.BackColor = System.Drawing.Color.Transparent
        Me._segment_25.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_25.Image = CType(resources.GetObject("_segment_25.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_25, CType(25, Short))
        Me._segment_25.Location = New System.Drawing.Point(200, 240)
        Me._segment_25.Name = "_segment_25"
        Me._segment_25.Size = New System.Drawing.Size(30, 30)
        Me._segment_25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_25.TabIndex = 96
        Me._segment_25.TabStop = False
        '
        '_segment_24
        '
        Me._segment_24.BackColor = System.Drawing.Color.Transparent
        Me._segment_24.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_24.Image = CType(resources.GetObject("_segment_24.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_24, CType(24, Short))
        Me._segment_24.Location = New System.Drawing.Point(200, 216)
        Me._segment_24.Name = "_segment_24"
        Me._segment_24.Size = New System.Drawing.Size(30, 30)
        Me._segment_24.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_24.TabIndex = 97
        Me._segment_24.TabStop = False
        '
        '_segment_23
        '
        Me._segment_23.BackColor = System.Drawing.Color.Transparent
        Me._segment_23.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_23.Image = CType(resources.GetObject("_segment_23.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_23, CType(23, Short))
        Me._segment_23.Location = New System.Drawing.Point(200, 264)
        Me._segment_23.Name = "_segment_23"
        Me._segment_23.Size = New System.Drawing.Size(30, 30)
        Me._segment_23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_23.TabIndex = 98
        Me._segment_23.TabStop = False
        '
        '_segment_22
        '
        Me._segment_22.BackColor = System.Drawing.Color.Transparent
        Me._segment_22.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_22.Image = CType(resources.GetObject("_segment_22.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_22, CType(22, Short))
        Me._segment_22.Location = New System.Drawing.Point(176, 216)
        Me._segment_22.Name = "_segment_22"
        Me._segment_22.Size = New System.Drawing.Size(30, 30)
        Me._segment_22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_22.TabIndex = 99
        Me._segment_22.TabStop = False
        '
        '_segment_21
        '
        Me._segment_21.BackColor = System.Drawing.Color.Transparent
        Me._segment_21.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_21.Image = CType(resources.GetObject("_segment_21.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_21, CType(21, Short))
        Me._segment_21.Location = New System.Drawing.Point(176, 240)
        Me._segment_21.Name = "_segment_21"
        Me._segment_21.Size = New System.Drawing.Size(30, 30)
        Me._segment_21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_21.TabIndex = 100
        Me._segment_21.TabStop = False
        '
        '_segment_20
        '
        Me._segment_20.BackColor = System.Drawing.Color.Transparent
        Me._segment_20.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_20.Image = CType(resources.GetObject("_segment_20.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_20, CType(20, Short))
        Me._segment_20.Location = New System.Drawing.Point(120, 248)
        Me._segment_20.Name = "_segment_20"
        Me._segment_20.Size = New System.Drawing.Size(30, 30)
        Me._segment_20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_20.TabIndex = 101
        Me._segment_20.TabStop = False
        '
        '_segment_19
        '
        Me._segment_19.BackColor = System.Drawing.Color.Transparent
        Me._segment_19.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_19.Image = CType(resources.GetObject("_segment_19.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_19, CType(19, Short))
        Me._segment_19.Location = New System.Drawing.Point(144, 248)
        Me._segment_19.Name = "_segment_19"
        Me._segment_19.Size = New System.Drawing.Size(30, 30)
        Me._segment_19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_19.TabIndex = 102
        Me._segment_19.TabStop = False
        '
        '_segment_18
        '
        Me._segment_18.BackColor = System.Drawing.Color.Transparent
        Me._segment_18.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_18.Image = CType(resources.GetObject("_segment_18.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_18, CType(18, Short))
        Me._segment_18.Location = New System.Drawing.Point(120, 224)
        Me._segment_18.Name = "_segment_18"
        Me._segment_18.Size = New System.Drawing.Size(30, 30)
        Me._segment_18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_18.TabIndex = 103
        Me._segment_18.TabStop = False
        '
        '_segment_17
        '
        Me._segment_17.BackColor = System.Drawing.Color.Transparent
        Me._segment_17.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_17.Image = CType(resources.GetObject("_segment_17.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_17, CType(17, Short))
        Me._segment_17.Location = New System.Drawing.Point(144, 224)
        Me._segment_17.Name = "_segment_17"
        Me._segment_17.Size = New System.Drawing.Size(30, 30)
        Me._segment_17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_17.TabIndex = 104
        Me._segment_17.TabStop = False
        '
        '_segment_16
        '
        Me._segment_16.BackColor = System.Drawing.Color.Transparent
        Me._segment_16.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_16.Image = CType(resources.GetObject("_segment_16.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_16, CType(16, Short))
        Me._segment_16.Location = New System.Drawing.Point(272, 0)
        Me._segment_16.Name = "_segment_16"
        Me._segment_16.Size = New System.Drawing.Size(30, 30)
        Me._segment_16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_16.TabIndex = 105
        Me._segment_16.TabStop = False
        '
        '_segment_15
        '
        Me._segment_15.BackColor = System.Drawing.Color.Transparent
        Me._segment_15.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_15.Image = CType(resources.GetObject("_segment_15.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_15, CType(15, Short))
        Me._segment_15.Location = New System.Drawing.Point(304, 0)
        Me._segment_15.Name = "_segment_15"
        Me._segment_15.Size = New System.Drawing.Size(30, 30)
        Me._segment_15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_15.TabIndex = 106
        Me._segment_15.TabStop = False
        '
        '_segment_14
        '
        Me._segment_14.BackColor = System.Drawing.Color.Transparent
        Me._segment_14.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_14.Image = CType(resources.GetObject("_segment_14.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_14, CType(14, Short))
        Me._segment_14.Location = New System.Drawing.Point(336, 0)
        Me._segment_14.Name = "_segment_14"
        Me._segment_14.Size = New System.Drawing.Size(30, 30)
        Me._segment_14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_14.TabIndex = 107
        Me._segment_14.TabStop = False
        '
        '_segment_13
        '
        Me._segment_13.BackColor = System.Drawing.Color.Transparent
        Me._segment_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_13.Image = CType(resources.GetObject("_segment_13.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_13, CType(13, Short))
        Me._segment_13.Location = New System.Drawing.Point(368, 0)
        Me._segment_13.Name = "_segment_13"
        Me._segment_13.Size = New System.Drawing.Size(30, 30)
        Me._segment_13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_13.TabIndex = 108
        Me._segment_13.TabStop = False
        '
        '_segment_12
        '
        Me._segment_12.BackColor = System.Drawing.Color.Transparent
        Me._segment_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_12.Image = CType(resources.GetObject("_segment_12.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_12, CType(12, Short))
        Me._segment_12.Location = New System.Drawing.Point(400, 0)
        Me._segment_12.Name = "_segment_12"
        Me._segment_12.Size = New System.Drawing.Size(30, 30)
        Me._segment_12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_12.TabIndex = 109
        Me._segment_12.TabStop = False
        '
        '_segment_11
        '
        Me._segment_11.BackColor = System.Drawing.Color.Transparent
        Me._segment_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_11.Image = CType(resources.GetObject("_segment_11.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_11, CType(11, Short))
        Me._segment_11.Location = New System.Drawing.Point(240, 32)
        Me._segment_11.Name = "_segment_11"
        Me._segment_11.Size = New System.Drawing.Size(30, 30)
        Me._segment_11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_11.TabIndex = 110
        Me._segment_11.TabStop = False
        '
        '_segment_10
        '
        Me._segment_10.BackColor = System.Drawing.Color.Transparent
        Me._segment_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_10.Image = CType(resources.GetObject("_segment_10.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_10, CType(10, Short))
        Me._segment_10.Location = New System.Drawing.Point(272, 32)
        Me._segment_10.Name = "_segment_10"
        Me._segment_10.Size = New System.Drawing.Size(30, 30)
        Me._segment_10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_10.TabIndex = 111
        Me._segment_10.TabStop = False
        '
        '_segment_9
        '
        Me._segment_9.BackColor = System.Drawing.Color.Transparent
        Me._segment_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_9.Image = CType(resources.GetObject("_segment_9.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_9, CType(9, Short))
        Me._segment_9.Location = New System.Drawing.Point(240, 0)
        Me._segment_9.Name = "_segment_9"
        Me._segment_9.Size = New System.Drawing.Size(30, 30)
        Me._segment_9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_9.TabIndex = 112
        Me._segment_9.TabStop = False
        '
        '_segment_8
        '
        Me._segment_8.BackColor = System.Drawing.Color.Transparent
        Me._segment_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_8.Image = CType(resources.GetObject("_segment_8.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_8, CType(8, Short))
        Me._segment_8.Location = New System.Drawing.Point(304, 32)
        Me._segment_8.Name = "_segment_8"
        Me._segment_8.Size = New System.Drawing.Size(30, 30)
        Me._segment_8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_8.TabIndex = 113
        Me._segment_8.TabStop = False
        '
        '_segment_7
        '
        Me._segment_7.BackColor = System.Drawing.Color.Transparent
        Me._segment_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_7.Image = CType(resources.GetObject("_segment_7.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_7, CType(7, Short))
        Me._segment_7.Location = New System.Drawing.Point(336, 32)
        Me._segment_7.Name = "_segment_7"
        Me._segment_7.Size = New System.Drawing.Size(30, 30)
        Me._segment_7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_7.TabIndex = 114
        Me._segment_7.TabStop = False
        '
        '_segment_6
        '
        Me._segment_6.BackColor = System.Drawing.Color.Transparent
        Me._segment_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_6.Image = CType(resources.GetObject("_segment_6.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_6, CType(6, Short))
        Me._segment_6.Location = New System.Drawing.Point(368, 32)
        Me._segment_6.Name = "_segment_6"
        Me._segment_6.Size = New System.Drawing.Size(30, 30)
        Me._segment_6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_6.TabIndex = 115
        Me._segment_6.TabStop = False
        '
        '_segment_5
        '
        Me._segment_5.BackColor = System.Drawing.Color.Transparent
        Me._segment_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_5.Image = CType(resources.GetObject("_segment_5.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_5, CType(5, Short))
        Me._segment_5.Location = New System.Drawing.Point(432, 0)
        Me._segment_5.Name = "_segment_5"
        Me._segment_5.Size = New System.Drawing.Size(30, 30)
        Me._segment_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_5.TabIndex = 116
        Me._segment_5.TabStop = False
        '
        '_segment_4
        '
        Me._segment_4.BackColor = System.Drawing.Color.Transparent
        Me._segment_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_4.Image = CType(resources.GetObject("_segment_4.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_4, CType(4, Short))
        Me._segment_4.Location = New System.Drawing.Point(464, 32)
        Me._segment_4.Name = "_segment_4"
        Me._segment_4.Size = New System.Drawing.Size(30, 30)
        Me._segment_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_4.TabIndex = 117
        Me._segment_4.TabStop = False
        '
        '_segment_3
        '
        Me._segment_3.BackColor = System.Drawing.Color.Transparent
        Me._segment_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_3.Image = CType(resources.GetObject("_segment_3.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_3, CType(3, Short))
        Me._segment_3.Location = New System.Drawing.Point(464, 0)
        Me._segment_3.Name = "_segment_3"
        Me._segment_3.Size = New System.Drawing.Size(30, 30)
        Me._segment_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_3.TabIndex = 118
        Me._segment_3.TabStop = False
        '
        '_segment_2
        '
        Me._segment_2.BackColor = System.Drawing.Color.Transparent
        Me._segment_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_2.Image = CType(resources.GetObject("_segment_2.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_2, CType(2, Short))
        Me._segment_2.Location = New System.Drawing.Point(400, 32)
        Me._segment_2.Name = "_segment_2"
        Me._segment_2.Size = New System.Drawing.Size(30, 30)
        Me._segment_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_2.TabIndex = 119
        Me._segment_2.TabStop = False
        '
        '_segment_1
        '
        Me._segment_1.BackColor = System.Drawing.Color.Transparent
        Me._segment_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._segment_1.Image = CType(resources.GetObject("_segment_1.Image"), System.Drawing.Image)
        Me.segment.SetIndex(Me._segment_1, CType(1, Short))
        Me._segment_1.Location = New System.Drawing.Point(432, 32)
        Me._segment_1.Name = "_segment_1"
        Me._segment_1.Size = New System.Drawing.Size(30, 30)
        Me._segment_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._segment_1.TabIndex = 120
        Me._segment_1.TabStop = False
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile, Me.mnuEdit, Me.mnuHelp})
        '
        'mnuFile
        '
        Me.mnuFile.Index = 0
        Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFileNew, Me.mnuFileExit})
        Me.mnuFile.Text = "&File"
        '
        'mnuFileNew
        '
        Me.mnuFileNew.Index = 0
        Me.mnuFileNew.Text = "&New"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Index = 1
        Me.mnuFileExit.Text = "E&xit"
        '
        'mnuEdit
        '
        Me.mnuEdit.Index = 1
        Me.mnuEdit.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuEditUndo})
        Me.mnuEdit.Text = "&Edit"
        '
        'mnuEditUndo
        '
        Me.mnuEditUndo.Index = 0
        Me.mnuEditUndo.Shortcut = System.Windows.Forms.Shortcut.CtrlZ
        Me.mnuEditUndo.Text = "&Undo"
        '
        'mnuHelp
        '
        Me.mnuHelp.Index = 2
        Me.mnuHelp.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MnuHelpRules, Me.mnuHelpAbout})
        Me.mnuHelp.Text = "&Help"
        '
        'MnuHelpRules
        '
        Me.MnuHelpRules.Index = 0
        Me.MnuHelpRules.Text = "&Rules"
        '
        'mnuHelpAbout
        '
        Me.mnuHelpAbout.Index = 1
        Me.mnuHelpAbout.Text = "&About"
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = New System.Drawing.Point(0, 395)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel1, Me.StatusBarPanel2, Me.StatusBarPanel3, Me.StatusBarPanel4, Me.StatusBarPanel5})
        Me.StatusBar1.ShowPanels = True
        Me.StatusBar1.Size = New System.Drawing.Size(496, 22)
        Me.StatusBar1.TabIndex = 122
        Me.StatusBar1.Text = "cntStatus"
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.Name = "StatusBarPanel1"
        Me.StatusBarPanel1.Text = "StatusBarPanel1"
        '
        'StatusBarPanel2
        '
        Me.StatusBarPanel2.Name = "StatusBarPanel2"
        Me.StatusBarPanel2.Text = "StatusBarPanel2"
        '
        'StatusBarPanel3
        '
        Me.StatusBarPanel3.Name = "StatusBarPanel3"
        Me.StatusBarPanel3.Text = "StatusBarPanel3"
        '
        'StatusBarPanel4
        '
        Me.StatusBarPanel4.Name = "StatusBarPanel4"
        Me.StatusBarPanel4.Text = "StatusBarPanel4"
        '
        'StatusBarPanel5
        '
        Me.StatusBarPanel5.Name = "StatusBarPanel5"
        Me.StatusBarPanel5.Text = "StatusBarPanel5"
        '
        'frmDiscon
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(496, 417)
        Me.Controls.Add(Me.StatusBar1)
        Me.Controls.Add(Me.Dragger)
        Me.Controls.Add(Me._ppiece_24)
        Me.Controls.Add(Me._ppiece_23)
        Me.Controls.Add(Me._ppiece_22)
        Me.Controls.Add(Me._ppiece_21)
        Me.Controls.Add(Me._ppiece_20)
        Me.Controls.Add(Me._ppiece_19)
        Me.Controls.Add(Me._ppiece_18)
        Me.Controls.Add(Me._ppiece_17)
        Me.Controls.Add(Me._ppiece_16)
        Me.Controls.Add(Me._ppiece_15)
        Me.Controls.Add(Me._ppiece_14)
        Me.Controls.Add(Me._ppiece_13)
        Me.Controls.Add(Me._ppiece_12)
        Me.Controls.Add(Me._ppiece_11)
        Me.Controls.Add(Me._ppiece_10)
        Me.Controls.Add(Me._ppiece_9)
        Me.Controls.Add(Me._ppiece_8)
        Me.Controls.Add(Me._ppiece_7)
        Me.Controls.Add(Me._ppiece_6)
        Me.Controls.Add(Me._ppiece_5)
        Me.Controls.Add(Me._ppiece_4)
        Me.Controls.Add(Me._ppiece_3)
        Me.Controls.Add(Me._ppiece_2)
        Me.Controls.Add(Me._ppiece_1)
        Me.Controls.Add(Me._segment_96)
        Me.Controls.Add(Me._segment_95)
        Me.Controls.Add(Me._segment_94)
        Me.Controls.Add(Me._segment_93)
        Me.Controls.Add(Me._segment_92)
        Me.Controls.Add(Me._segment_91)
        Me.Controls.Add(Me._segment_90)
        Me.Controls.Add(Me._segment_89)
        Me.Controls.Add(Me._segment_88)
        Me.Controls.Add(Me._segment_87)
        Me.Controls.Add(Me._segment_86)
        Me.Controls.Add(Me._segment_85)
        Me.Controls.Add(Me._segment_84)
        Me.Controls.Add(Me._segment_83)
        Me.Controls.Add(Me._segment_82)
        Me.Controls.Add(Me._segment_81)
        Me.Controls.Add(Me._segment_80)
        Me.Controls.Add(Me._segment_79)
        Me.Controls.Add(Me._segment_78)
        Me.Controls.Add(Me._segment_77)
        Me.Controls.Add(Me._segment_76)
        Me.Controls.Add(Me._segment_75)
        Me.Controls.Add(Me._segment_74)
        Me.Controls.Add(Me._segment_73)
        Me.Controls.Add(Me._segment_72)
        Me.Controls.Add(Me._segment_71)
        Me.Controls.Add(Me._segment_70)
        Me.Controls.Add(Me._segment_69)
        Me.Controls.Add(Me._segment_68)
        Me.Controls.Add(Me._segment_67)
        Me.Controls.Add(Me._segment_66)
        Me.Controls.Add(Me._segment_65)
        Me.Controls.Add(Me._segment_64)
        Me.Controls.Add(Me._segment_63)
        Me.Controls.Add(Me._segment_62)
        Me.Controls.Add(Me._segment_61)
        Me.Controls.Add(Me._segment_60)
        Me.Controls.Add(Me._segment_59)
        Me.Controls.Add(Me._segment_58)
        Me.Controls.Add(Me._segment_57)
        Me.Controls.Add(Me._segment_56)
        Me.Controls.Add(Me._segment_55)
        Me.Controls.Add(Me._segment_54)
        Me.Controls.Add(Me._segment_53)
        Me.Controls.Add(Me._segment_52)
        Me.Controls.Add(Me._segment_51)
        Me.Controls.Add(Me._segment_50)
        Me.Controls.Add(Me._segment_49)
        Me.Controls.Add(Me._segment_48)
        Me.Controls.Add(Me._segment_47)
        Me.Controls.Add(Me._segment_46)
        Me.Controls.Add(Me._segment_45)
        Me.Controls.Add(Me._segment_44)
        Me.Controls.Add(Me._segment_43)
        Me.Controls.Add(Me._segment_42)
        Me.Controls.Add(Me._segment_41)
        Me.Controls.Add(Me._segment_40)
        Me.Controls.Add(Me._segment_39)
        Me.Controls.Add(Me._segment_38)
        Me.Controls.Add(Me._segment_37)
        Me.Controls.Add(Me._segment_36)
        Me.Controls.Add(Me._segment_35)
        Me.Controls.Add(Me._segment_34)
        Me.Controls.Add(Me._segment_33)
        Me.Controls.Add(Me._segment_32)
        Me.Controls.Add(Me._segment_31)
        Me.Controls.Add(Me._segment_30)
        Me.Controls.Add(Me._segment_29)
        Me.Controls.Add(Me._segment_28)
        Me.Controls.Add(Me._segment_27)
        Me.Controls.Add(Me._segment_26)
        Me.Controls.Add(Me._segment_25)
        Me.Controls.Add(Me._segment_24)
        Me.Controls.Add(Me._segment_23)
        Me.Controls.Add(Me._segment_22)
        Me.Controls.Add(Me._segment_21)
        Me.Controls.Add(Me._segment_20)
        Me.Controls.Add(Me._segment_19)
        Me.Controls.Add(Me._segment_18)
        Me.Controls.Add(Me._segment_17)
        Me.Controls.Add(Me._segment_16)
        Me.Controls.Add(Me._segment_15)
        Me.Controls.Add(Me._segment_14)
        Me.Controls.Add(Me._segment_13)
        Me.Controls.Add(Me._segment_12)
        Me.Controls.Add(Me._segment_11)
        Me.Controls.Add(Me._segment_10)
        Me.Controls.Add(Me._segment_9)
        Me.Controls.Add(Me._segment_8)
        Me.Controls.Add(Me._segment_7)
        Me.Controls.Add(Me._segment_6)
        Me.Controls.Add(Me._segment_5)
        Me.Controls.Add(Me._segment_4)
        Me.Controls.Add(Me._segment_3)
        Me.Controls.Add(Me._segment_2)
        Me.Controls.Add(Me._segment_1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(11, 30)
        Me.Menu = Me.MainMenu1
        Me.Name = "frmDiscon"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Discon"
        CType(Me._ppiece_6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._ppiece_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._ppiece_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._ppiece_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._ppiece_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._ppiece_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dragger, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._ppiece_24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._ppiece_23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._ppiece_22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._ppiece_21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._ppiece_20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._ppiece_19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._ppiece_18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._ppiece_17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._ppiece_16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._ppiece_15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._ppiece_14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._ppiece_13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._ppiece_12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._ppiece_11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._ppiece_10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._ppiece_9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._ppiece_8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._ppiece_7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_96, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_95, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_94, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_93, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_92, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_91, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_90, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_89, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_88, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_87, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_86, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_85, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_84, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_83, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_82, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_81, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_80, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_79, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_78, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_77, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_76, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_75, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_74, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_73, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_72, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_71, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_70, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_69, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_68, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_67, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_66, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_65, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_64, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_63, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_62, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_61, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_60, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_59, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_58, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_57, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_56, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_55, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_54, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_53, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_52, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_51, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_50, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_49, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_48, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_47, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_46, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_45, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_44, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_43, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_42, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_40, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_39, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_38, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_37, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_36, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_35, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._segment_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ppiece, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.segment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
#Region "Upgrade Support "
    Private Shared m_vb6FormDefInstance As FrmDiscon
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As FrmDiscon
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmDiscon()
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal value As FrmDiscon)
            m_vb6FormDefInstance = value
        End Set
    End Property
#End Region

    Private mouseButton As Short 'when the mouse button is clicked record which button is used.
    Private aBoard As New Board
    Private aSegments As New Segments
    Private aPPieces As New PPieces(12)
    Private aTurn As New Turn
    Private IsUDraggin As Boolean 'Drop and Drag support of PPieces
    Private IsUDisplayin As Boolean 'While displaying disable drag and drop
    Private origX As Long
    Private origY As Long
    Private GameOver As Boolean

    'Event handlers
    Private Sub FrmDiscon_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Closed
        End
    End Sub

    Private Sub FrmDiscon_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        'Set up the game -- All New objects should be created here.... (i.e. have other Init routines for File New Game that don't create new objects. Reuse objects
        mouseButton = VB6.MouseButtonConstants.LeftButton 'default button is left

        frmHistory.Show()

        aTurn = New Turn 'Create objects for game: Turn class keeps track of who's turn it is / incl. basic game/rule info like MaxHeight
        aBoard = New Board 'Board class keeps track of where pieces are and relates closely to frmDiscon
        aSegments = New Segments 'A collection of coloured discs
        aSegments.Setup(aBoard) 'layout the coloured discs on the board and then randomize them
        aSegments.Draw()
        'Me.Invalidate()
        'aSegments.Resize()
        'aPPieces.ReSize()

        frmPreferences.ShowDialog() 'Find out who's playing
        aTurn.Init() 'works our active players and maxheight and who'll go first
        aPPieces = New PPieces(aTurn.MaxHeight) 'The players each have six red playing pieces This is a collection of them -- (Max Height is stored here based on number of players see instructiosn)
        aPPieces.Setup(aBoard) 'They are positioned in each of the four corners
        aPPieces.Draw()

        GameOver = False

        ' Have any computer turns
        Do While aTurn.GetPlayer.Status = 2 And Not GameOver 'Computer
            aTurn.GetPlayer.CompMove(aPPieces, aSegments, aTurn)
            frmHistory.Cout(aTurn.Message & vbNewLine)
            If CountOwned() = aSegments.MaxSegments() Then
                GameOver = True
                MsgBox(aTurn.LeadingPlayer() & " won.")
            End If
        Loop
        ShowStatus() 'Let people know whose turn it is

    End Sub

    Private Sub FrmDiscon_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        aBoard.draw(e.Graphics)
    End Sub

    Private Sub FrmDiscon_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
        Dim minDim As Short

        If VB6.PixelsToTwipsY(Me.ClientRectangle.Height) > VB6.PixelsToTwipsX(Me.ClientRectangle.Width) Then
            minDim = VB6.PixelsToTwipsX(Me.ClientRectangle.Width)
        Else
            minDim = VB6.PixelsToTwipsY(Me.ClientRectangle.Height)
        End If
        aBoard.positionHeight = minDim / (aBoard.maxY + 2)
        aBoard.positionWidth = aBoard.positionHeight
        Me.Invalidate()
        aSegments.Draw()
        aSegments.Resize()
        aPPieces.Draw()
        aPPieces.ReSize()
    End Sub

    Private Sub Ppiece_1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles _ppiece_1.MouseUp, _ppiece_2.MouseUp, _ppiece_3.MouseUp, _ppiece_4.MouseUp, _ppiece_5.MouseUp, _ppiece_6.MouseUp, _ppiece_7.MouseUp, _ppiece_8.MouseUp, _ppiece_9.MouseUp, _ppiece_10.MouseUp, _ppiece_11.MouseUp, _ppiece_12.MouseUp, _ppiece_13.MouseUp, _ppiece_14.MouseUp, _ppiece_15.MouseUp, _ppiece_16.MouseUp, _ppiece_17.MouseUp, _ppiece_18.MouseUp, _ppiece_19.MouseUp, _ppiece_20.MouseUp, _ppiece_21.MouseUp, _ppiece_22.MouseUp, _ppiece_23.MouseUp, _ppiece_24.MouseUp
        'release the playing piece. 'e.x and e.y are pixel position within the piece
        Dim aPiece As PPiece 'Player piece
        Dim aXFinish As Short
        Dim aYFinish As Short

        If IsUDraggin Then
            IsUDraggin = False
            aPiece = aPPieces.GetPiece(sender.Tag) 'This is who (which player piece to be precise) moved
            aXFinish = aBoard.getXPosFromMouse(sender.left)
            aYFinish = aBoard.getYPosFromMouse(sender.top)
            If aXFinish = aPiece.XPos And aYFinish = aPiece.YPos Then '(We just clicked on the thing
                DisplayTower(sender)
            Else 'we tried to move somewhere
                Segment_DragDrop(sender, aXFinish, aYFinish)
            End If

        End If
    End Sub

    Private Sub PPieceMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles _ppiece_1.MouseDown, _ppiece_2.MouseDown, _ppiece_3.MouseDown, _ppiece_4.MouseDown, _ppiece_5.MouseDown, _ppiece_6.MouseDown, _ppiece_7.MouseDown, _ppiece_8.MouseDown, _ppiece_9.MouseDown, _ppiece_10.MouseDown, _ppiece_11.MouseDown, _ppiece_12.MouseDown, _ppiece_13.MouseDown, _ppiece_14.MouseDown, _ppiece_15.MouseDown, _ppiece_16.MouseDown, _ppiece_17.MouseDown, _ppiece_18.MouseDown, _ppiece_19.MouseDown, _ppiece_20.MouseDown, _ppiece_21.MouseDown, _ppiece_22.MouseDown, _ppiece_23.MouseDown, _ppiece_24.MouseDown
        'This code is designed for picking up a player piece with the mouse
        'e contains the mouse position
        'the sender is the object that detected the mousedown event... should be the player piece
        'e.x and e.y are pixel position within the piece
        'add them to the sender.left and sender.top to derive the mouse position on the form
        If Not GameOver And Not IsUDraggin And Not IsUDisplayin Then 'Not dragging and not displaying
            IsUDraggin = True
            origX = e.X 'remember where we started from (clicked)
            origY = e.Y
            If e.Button = MouseButtons.Right Then
                mouseButton = VB6.MouseButtonConstants.RightButton
            Else
                mouseButton = VB6.MouseButtonConstants.LeftButton
            End If
        End If
    End Sub

    Private Sub PPieceMouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles _ppiece_1.MouseMove, _ppiece_2.MouseMove, _ppiece_3.MouseMove, _ppiece_4.MouseMove, _ppiece_5.MouseMove, _ppiece_6.MouseMove, _ppiece_7.MouseMove, _ppiece_8.MouseMove, _ppiece_9.MouseMove, _ppiece_10.MouseMove, _ppiece_11.MouseMove, _ppiece_12.MouseMove, _ppiece_13.MouseMove, _ppiece_14.MouseMove, _ppiece_15.MouseMove, _ppiece_16.MouseMove, _ppiece_17.MouseMove, _ppiece_18.MouseMove, _ppiece_19.MouseMove, _ppiece_20.MouseMove, _ppiece_21.MouseMove, _ppiece_22.MouseMove, _ppiece_23.MouseMove, _ppiece_24.MouseMove
        'Reposition the player piece
        'e.x and e.y are relative pixel position within the piece
        'add them to the sender.left and sender.top to derive the mouse position on the form
        If IsUDraggin Then
            'sender is Player piece control (picturebox)
            sender.Left = sender.left + e.X - origX
            sender.Top = sender.top + e.Y - origY
        End If
    End Sub

    'Menu
    Public Sub MnuFileExit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuFileExit.Click
        End
    End Sub

    Public Sub MnuFileNew_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuFileNew.Click

        frmPreferences.ShowDialog() 'popup to ask about players
        aTurn.Init() 'Turn object works out active players, maximum tower height and who'll go first
        aSegments.Setup(aBoard) 'segments are drawn and randomized
        aPPieces.Setup(aBoard)
        aPPieces.MaxHeight = aTurn.MaxHeight 'The pieces, have towers and, when adding, they need to know about height restrictions.
        GameOver = False

        'if computer has first move initiate that
        Do While aTurn.GetPlayer.Status = 2 And Not GameOver 'Computer
            aTurn.GetPlayer.CompMove(aPPieces, aSegments, aTurn)
            frmHistory.Cout(aTurn.Message & vbNewLine)
            If CountOwned() = aSegments.MaxSegments() Then
                GameOver = True
                MsgBox(aTurn.LeadingPlayer() & " won.")
            End If
        Loop
        ShowStatus()

    End Sub

    Public Sub MnuEditUndo_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuEditUndo.Click
        aTurn.Undo(1)
        ShowStatus() 'Because move is possible wrong
    End Sub

    Private Sub MnuHelpRules_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuHelpRules.Click
        Try
            Dim AppPath As String = System.AppDomain.CurrentDomain.BaseDirectory
            System.Diagnostics.Process.Start(AppPath + "DisconHelp.html")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MnuHelpAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHelpAbout.Click
        frmAbout.Show()
    End Sub

    'Helper routines
    Private Function CountOwned() As Object
        'Check progress in game by counting 'captured' segments. 96 = GameOver
        Dim i As Short

        CountOwned = 0
        For i = 1 To aTurn.MaxPlayer * aTurn.MaxPPiece 'MaxPlayer 24 '4 players * 6 player pieces
            CountOwned += aPPieces.GetPiece(i).GetTower.Height
        Next
    End Function

    Private Sub DisplayTower(ByRef Source As System.Windows.Forms.Control)
        'Click and release on a player piece displays tower
        'Called (see below) from mouseup after determining no actual move has occured (click on self)
        Dim aPiece As PPiece
        Dim i As Integer

        If Not IsUDisplayin Then
            IsUDisplayin = True 'prevent drag and drop
            aPiece = aPPieces.GetPiece(Source.Tag)
            aPiece.Displayed = True
            aPiece.DisplayTower()
            For i = 1 To 10
                Application.DoEvents()
                System.Threading.Thread.Sleep(100)
            Next
            aPiece.Displayed = False
            aPiece.Draw()
            IsUDisplayin = False
        End If

    End Sub

    Private Sub Segment_DragDrop(ByRef Source As System.Windows.Forms.Control, ByRef x As Single, ByRef y As Single)
        'The routine handles a player piece attempting to capture a segment (a normal move)
        'The source is the PPiece
        'called from mouseup after dragging
        Dim aPiece As PPiece 'a pointer to a player Piece
        Dim aSegment As Segment 'a pointer to a segment that might be at the destination
        Dim aPlayer As Player
        Dim oldValue As Short 'each move, find change in score and add it to player score
        Dim newValue As Short 'scoring

        aPiece = aPPieces.GetPiece(Source.Tag) 'This is who (which piece to be precise) moved
        'we could pass apiece from the mouseup routine as we've worked it out there already
        aPlayer = aTurn.GetPlayer 'This is who's turn it is
        If aPlayer.ID <> aPiece.Owner Then
            MsgBox("It's player number " & aPlayer.ID & "'s turn.")
            'aPiece.Draw() 'aPPieces.draw()
        Else 'the right person has had a turn
            oldValue = aPiece.Score 'remember the current score
            aTurn.SaveSource(aPiece) 'Before move, remember for undo
            If mouseButton = VB6.MouseButtonConstants.LeftButton Then 'clicking on a new segment to capture it
                If aPiece.Move(x, y) Then 'move player piece (image and object including existing tower) if destination is legal
                    aSegment = aSegments.GetSegmentXY(x, y) 'Note: there maybe more than one this is basically a test that it's not empty...
                    If aSegment IsNot Nothing Then 'There are one or more segments to add
                        If aSegments.AddAny(aPiece) Then 'Add any segments found that are not already in the tower if not > Tower MaxHeight
                            aTurn.IncMove() 'count move. If second, check you're not in foreign territory
                        Else
                            MsgBox(aSegments.Message) 'Problem adding: display reason
                            aTurn.Undo(2) 'The piece and it's tower segments should all return to the position before move 1 of this player's turn
                        End If
                    Else
                        aTurn.IncMove() 'count moves. If second, check you're not in foreign territory
                    End If
                Else 'illegal move
                    MsgBox("Illegal move from " & aPiece.XPos & ", " & aPiece.YPos & " to " & x & ", " & y) 'no need to undo
                    'aPiece.Draw()
                End If
            Else 'right click is for abandoning a pile of segments
                If aPiece.Abandon(x, y) Then 'move player piece (image and object removes tower and updates) (but not tower yet) if destination is legal
                    If aSegments.AddAny(aPiece) Then
                        aTurn.IncMove()
                    Else
                        aTurn.Undo(2)
                    End If
                Else
                    MsgBox("Illegal abandon from " & aPiece.XPos & ", " & aPiece.YPos & " to " & x & ", " & y)
                End If
            End If
            newValue = aPiece.Score
            aPiece.UpdateTooltip() 'to display colour and height
            aPiece.Draw()
            aPlayer.Score = aPlayer.Score - oldValue + newValue 'aPlayer.GetScore could just sum all piece scores
            If aTurn.Move = 2 Then 'incMove generally happens before this so this means we've just finished move 1
                aTurn.Message = aPiece.Owner & ":" & aPiece.PPID & " to " & aPiece.XPos & ", " & aPiece.YPos
            Else
                aTurn.Message += " and " & aPiece.PPID & " to " & aPiece.XPos & ", " & aPiece.YPos
                frmHistory.Cout(aTurn.Message & vbNewLine)
            End If
            If CountOwned() = aSegments.MaxSegments() Then
                GameOver = True
                MsgBox(aTurn.LeadingPlayer() & " won.")
            End If
            ShowStatus()
        End If

        Do While aTurn.GetPlayer.Status = 2 And Not GameOver 'Computer
            Application.DoEvents()
            aTurn.GetPlayer.CompMove(aPPieces, aSegments, aTurn)
            frmHistory.Cout(aTurn.Message & vbNewLine)
            If CountOwned() = aSegments.MaxSegments() Then
                GameOver = True
                MsgBox(aTurn.LeadingPlayer() & " won.")
            End If
            ShowStatus()
        Loop

    End Sub

    Sub ShowStatus()
        'Display players scores on status bar.
        Dim p As Short
        Dim aSB As Windows.Forms.StatusBar

        aSB = StatusBar1
        aSB.Panels(0).Text = "Player " & aTurn.Player & " move " & aTurn.Move
        For p = 1 To aTurn.MaxPlayer
            If aTurn.Status(p) = 1 Or aTurn.Status(p) = 2 Then 'this player is in the game
                aSB.Panels(p).Text = "Score " & p & ": " & aTurn.Score(p)
            Else
                aSB.Panels(p).Text = ""
            End If
        Next p
    End Sub


End Class
