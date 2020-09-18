Option Strict Off
Option Explicit On
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

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
    Public WithEvents PPiece_24 As System.Windows.Forms.PictureBox
    Public WithEvents PPiece_23 As System.Windows.Forms.PictureBox
    Public WithEvents PPiece_22 As System.Windows.Forms.PictureBox
    Public WithEvents PPiece_21 As System.Windows.Forms.PictureBox
    Public WithEvents PPiece_20 As System.Windows.Forms.PictureBox
    Public WithEvents PPiece_19 As System.Windows.Forms.PictureBox
    Public WithEvents PPiece_18 As System.Windows.Forms.PictureBox
    Public WithEvents PPiece_17 As System.Windows.Forms.PictureBox
    Public WithEvents PPiece_16 As System.Windows.Forms.PictureBox
    Public WithEvents PPiece_15 As System.Windows.Forms.PictureBox
    Public WithEvents PPiece_14 As System.Windows.Forms.PictureBox
    Public WithEvents PPiece_13 As System.Windows.Forms.PictureBox
    Public WithEvents PPiece_12 As System.Windows.Forms.PictureBox
    Public WithEvents PPiece_11 As System.Windows.Forms.PictureBox
    Public WithEvents PPiece_10 As System.Windows.Forms.PictureBox
    Public WithEvents PPiece_9 As System.Windows.Forms.PictureBox
    Public WithEvents PPiece_8 As System.Windows.Forms.PictureBox
    Public WithEvents PPiece_7 As System.Windows.Forms.PictureBox
    Public WithEvents PPiece_6 As System.Windows.Forms.PictureBox
    Public WithEvents PPiece_5 As System.Windows.Forms.PictureBox
    Public WithEvents PPiece_4 As System.Windows.Forms.PictureBox
    Public WithEvents PPiece_3 As System.Windows.Forms.PictureBox
    Public WithEvents PPiece_2 As System.Windows.Forms.PictureBox
    Public WithEvents PPiece_1 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_96 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_95 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_94 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_93 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_92 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_91 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_90 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_89 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_88 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_87 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_86 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_85 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_84 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_83 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_82 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_81 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_80 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_79 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_78 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_77 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_76 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_75 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_74 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_73 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_72 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_71 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_70 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_69 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_68 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_67 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_66 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_65 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_64 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_63 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_62 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_61 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_60 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_59 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_58 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_57 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_56 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_55 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_54 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_53 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_52 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_51 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_50 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_49 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_48 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_47 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_46 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_45 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_44 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_43 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_42 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_41 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_40 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_39 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_38 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_37 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_36 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_35 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_34 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_33 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_32 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_31 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_30 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_29 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_28 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_27 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_26 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_25 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_24 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_23 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_22 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_21 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_20 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_19 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_18 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_17 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_16 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_15 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_14 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_13 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_12 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_11 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_10 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_9 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_8 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_7 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_6 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_5 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_4 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_3 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_2 As System.Windows.Forms.PictureBox
    Public WithEvents Segment_1 As System.Windows.Forms.PictureBox
    Public WithEvents PPiece As Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray
    Public WithEvents Segment As Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray
    Public WithEvents MnuFileNew As System.Windows.Forms.MenuItem
    Public WithEvents MnuFileExit As System.Windows.Forms.MenuItem
    Public WithEvents MnuFile As System.Windows.Forms.MenuItem
    Public WithEvents MnuEditUndo As System.Windows.Forms.MenuItem
    Public WithEvents MnuEdit As System.Windows.Forms.MenuItem
    Public WithEvents MnuHelp As System.Windows.Forms.MenuItem
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
    Friend WithEvents MnuSave As MenuItem
    Friend WithEvents MnuLoad As MenuItem
    Friend WithEvents MnuEditOptions As MenuItem
    Friend WithEvents MnuHelpAbout As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDiscon))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PPiece_6 = New System.Windows.Forms.PictureBox()
        Me.PPiece_5 = New System.Windows.Forms.PictureBox()
        Me.PPiece_4 = New System.Windows.Forms.PictureBox()
        Me.PPiece_3 = New System.Windows.Forms.PictureBox()
        Me.PPiece_2 = New System.Windows.Forms.PictureBox()
        Me.PPiece_1 = New System.Windows.Forms.PictureBox()
        Me.Dragger = New System.Windows.Forms.PictureBox()
        Me.PPiece_24 = New System.Windows.Forms.PictureBox()
        Me.PPiece_23 = New System.Windows.Forms.PictureBox()
        Me.PPiece_22 = New System.Windows.Forms.PictureBox()
        Me.PPiece_21 = New System.Windows.Forms.PictureBox()
        Me.PPiece_20 = New System.Windows.Forms.PictureBox()
        Me.PPiece_19 = New System.Windows.Forms.PictureBox()
        Me.PPiece_18 = New System.Windows.Forms.PictureBox()
        Me.PPiece_17 = New System.Windows.Forms.PictureBox()
        Me.PPiece_16 = New System.Windows.Forms.PictureBox()
        Me.PPiece_15 = New System.Windows.Forms.PictureBox()
        Me.PPiece_14 = New System.Windows.Forms.PictureBox()
        Me.PPiece_13 = New System.Windows.Forms.PictureBox()
        Me.PPiece_12 = New System.Windows.Forms.PictureBox()
        Me.PPiece_11 = New System.Windows.Forms.PictureBox()
        Me.PPiece_10 = New System.Windows.Forms.PictureBox()
        Me.PPiece_9 = New System.Windows.Forms.PictureBox()
        Me.PPiece_8 = New System.Windows.Forms.PictureBox()
        Me.PPiece_7 = New System.Windows.Forms.PictureBox()
        Me.Segment_96 = New System.Windows.Forms.PictureBox()
        Me.Segment_95 = New System.Windows.Forms.PictureBox()
        Me.Segment_94 = New System.Windows.Forms.PictureBox()
        Me.Segment_93 = New System.Windows.Forms.PictureBox()
        Me.Segment_92 = New System.Windows.Forms.PictureBox()
        Me.Segment_91 = New System.Windows.Forms.PictureBox()
        Me.Segment_90 = New System.Windows.Forms.PictureBox()
        Me.Segment_89 = New System.Windows.Forms.PictureBox()
        Me.Segment_88 = New System.Windows.Forms.PictureBox()
        Me.Segment_87 = New System.Windows.Forms.PictureBox()
        Me.Segment_86 = New System.Windows.Forms.PictureBox()
        Me.Segment_85 = New System.Windows.Forms.PictureBox()
        Me.Segment_84 = New System.Windows.Forms.PictureBox()
        Me.Segment_83 = New System.Windows.Forms.PictureBox()
        Me.Segment_82 = New System.Windows.Forms.PictureBox()
        Me.Segment_81 = New System.Windows.Forms.PictureBox()
        Me.Segment_80 = New System.Windows.Forms.PictureBox()
        Me.Segment_79 = New System.Windows.Forms.PictureBox()
        Me.Segment_78 = New System.Windows.Forms.PictureBox()
        Me.Segment_77 = New System.Windows.Forms.PictureBox()
        Me.Segment_76 = New System.Windows.Forms.PictureBox()
        Me.Segment_75 = New System.Windows.Forms.PictureBox()
        Me.Segment_74 = New System.Windows.Forms.PictureBox()
        Me.Segment_73 = New System.Windows.Forms.PictureBox()
        Me.Segment_72 = New System.Windows.Forms.PictureBox()
        Me.Segment_71 = New System.Windows.Forms.PictureBox()
        Me.Segment_70 = New System.Windows.Forms.PictureBox()
        Me.Segment_69 = New System.Windows.Forms.PictureBox()
        Me.Segment_68 = New System.Windows.Forms.PictureBox()
        Me.Segment_67 = New System.Windows.Forms.PictureBox()
        Me.Segment_66 = New System.Windows.Forms.PictureBox()
        Me.Segment_65 = New System.Windows.Forms.PictureBox()
        Me.Segment_64 = New System.Windows.Forms.PictureBox()
        Me.Segment_63 = New System.Windows.Forms.PictureBox()
        Me.Segment_62 = New System.Windows.Forms.PictureBox()
        Me.Segment_61 = New System.Windows.Forms.PictureBox()
        Me.Segment_60 = New System.Windows.Forms.PictureBox()
        Me.Segment_59 = New System.Windows.Forms.PictureBox()
        Me.Segment_58 = New System.Windows.Forms.PictureBox()
        Me.Segment_57 = New System.Windows.Forms.PictureBox()
        Me.Segment_56 = New System.Windows.Forms.PictureBox()
        Me.Segment_55 = New System.Windows.Forms.PictureBox()
        Me.Segment_54 = New System.Windows.Forms.PictureBox()
        Me.Segment_53 = New System.Windows.Forms.PictureBox()
        Me.Segment_52 = New System.Windows.Forms.PictureBox()
        Me.Segment_51 = New System.Windows.Forms.PictureBox()
        Me.Segment_50 = New System.Windows.Forms.PictureBox()
        Me.Segment_49 = New System.Windows.Forms.PictureBox()
        Me.Segment_48 = New System.Windows.Forms.PictureBox()
        Me.Segment_47 = New System.Windows.Forms.PictureBox()
        Me.Segment_46 = New System.Windows.Forms.PictureBox()
        Me.Segment_45 = New System.Windows.Forms.PictureBox()
        Me.Segment_44 = New System.Windows.Forms.PictureBox()
        Me.Segment_43 = New System.Windows.Forms.PictureBox()
        Me.Segment_42 = New System.Windows.Forms.PictureBox()
        Me.Segment_41 = New System.Windows.Forms.PictureBox()
        Me.Segment_40 = New System.Windows.Forms.PictureBox()
        Me.Segment_39 = New System.Windows.Forms.PictureBox()
        Me.Segment_38 = New System.Windows.Forms.PictureBox()
        Me.Segment_37 = New System.Windows.Forms.PictureBox()
        Me.Segment_36 = New System.Windows.Forms.PictureBox()
        Me.Segment_35 = New System.Windows.Forms.PictureBox()
        Me.Segment_34 = New System.Windows.Forms.PictureBox()
        Me.Segment_33 = New System.Windows.Forms.PictureBox()
        Me.Segment_32 = New System.Windows.Forms.PictureBox()
        Me.Segment_31 = New System.Windows.Forms.PictureBox()
        Me.Segment_30 = New System.Windows.Forms.PictureBox()
        Me.Segment_29 = New System.Windows.Forms.PictureBox()
        Me.Segment_28 = New System.Windows.Forms.PictureBox()
        Me.Segment_27 = New System.Windows.Forms.PictureBox()
        Me.Segment_26 = New System.Windows.Forms.PictureBox()
        Me.Segment_25 = New System.Windows.Forms.PictureBox()
        Me.Segment_24 = New System.Windows.Forms.PictureBox()
        Me.Segment_23 = New System.Windows.Forms.PictureBox()
        Me.Segment_22 = New System.Windows.Forms.PictureBox()
        Me.Segment_21 = New System.Windows.Forms.PictureBox()
        Me.Segment_20 = New System.Windows.Forms.PictureBox()
        Me.Segment_19 = New System.Windows.Forms.PictureBox()
        Me.Segment_18 = New System.Windows.Forms.PictureBox()
        Me.Segment_17 = New System.Windows.Forms.PictureBox()
        Me.Segment_16 = New System.Windows.Forms.PictureBox()
        Me.Segment_15 = New System.Windows.Forms.PictureBox()
        Me.Segment_14 = New System.Windows.Forms.PictureBox()
        Me.Segment_13 = New System.Windows.Forms.PictureBox()
        Me.Segment_12 = New System.Windows.Forms.PictureBox()
        Me.Segment_11 = New System.Windows.Forms.PictureBox()
        Me.Segment_10 = New System.Windows.Forms.PictureBox()
        Me.Segment_9 = New System.Windows.Forms.PictureBox()
        Me.Segment_8 = New System.Windows.Forms.PictureBox()
        Me.Segment_7 = New System.Windows.Forms.PictureBox()
        Me.Segment_6 = New System.Windows.Forms.PictureBox()
        Me.Segment_5 = New System.Windows.Forms.PictureBox()
        Me.Segment_4 = New System.Windows.Forms.PictureBox()
        Me.Segment_3 = New System.Windows.Forms.PictureBox()
        Me.Segment_2 = New System.Windows.Forms.PictureBox()
        Me.Segment_1 = New System.Windows.Forms.PictureBox()
        Me.PPiece = New Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray(Me.components)
        Me.Segment = New Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray(Me.components)
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MnuFile = New System.Windows.Forms.MenuItem()
        Me.MnuFileNew = New System.Windows.Forms.MenuItem()
        Me.MnuSave = New System.Windows.Forms.MenuItem()
        Me.MnuLoad = New System.Windows.Forms.MenuItem()
        Me.MnuFileExit = New System.Windows.Forms.MenuItem()
        Me.MnuEdit = New System.Windows.Forms.MenuItem()
        Me.MnuEditUndo = New System.Windows.Forms.MenuItem()
        Me.MnuHelp = New System.Windows.Forms.MenuItem()
        Me.MnuHelpRules = New System.Windows.Forms.MenuItem()
        Me.MnuHelpAbout = New System.Windows.Forms.MenuItem()
        Me.StatusBar1 = New System.Windows.Forms.StatusBar()
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel()
        Me.StatusBarPanel2 = New System.Windows.Forms.StatusBarPanel()
        Me.StatusBarPanel3 = New System.Windows.Forms.StatusBarPanel()
        Me.StatusBarPanel4 = New System.Windows.Forms.StatusBarPanel()
        Me.StatusBarPanel5 = New System.Windows.Forms.StatusBarPanel()
        Me.MnuEditOptions = New System.Windows.Forms.MenuItem()
        CType(Me.PPiece_6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PPiece_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PPiece_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PPiece_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PPiece_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PPiece_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dragger, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PPiece_24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PPiece_23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PPiece_22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PPiece_21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PPiece_20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PPiece_19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PPiece_18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PPiece_17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PPiece_16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PPiece_15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PPiece_14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PPiece_13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PPiece_12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PPiece_11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PPiece_10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PPiece_9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PPiece_8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PPiece_7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_96, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_95, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_94, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_93, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_92, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_91, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_90, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_89, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_88, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_87, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_86, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_85, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_84, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_83, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_82, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_81, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_80, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_79, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_78, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_77, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_76, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_75, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_74, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_73, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_72, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_71, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_70, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_69, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_68, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_67, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_66, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_65, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_64, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_63, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_62, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_61, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_60, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_59, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_58, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_57, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_56, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_55, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_54, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_53, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_52, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_51, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_50, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_49, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_48, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_47, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_46, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_45, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_44, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_43, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_42, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_40, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_39, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_38, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_37, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_36, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_35, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PPiece, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PPiece_6
        '
        Me.PPiece_6.BackColor = System.Drawing.Color.Transparent
        Me.PPiece_6.Cursor = System.Windows.Forms.Cursors.Default
        Me.PPiece_6.Image = CType(resources.GetObject("PPiece_6.Image"), System.Drawing.Image)
        Me.PPiece.SetIndex(Me.PPiece_6, CType(6, Short))
        Me.PPiece_6.Location = New System.Drawing.Point(200, 96)
        Me.PPiece_6.Name = "PPiece_6"
        Me.PPiece_6.Size = New System.Drawing.Size(30, 30)
        Me.PPiece_6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PPiece_6.TabIndex = 19
        Me.PPiece_6.TabStop = False
        Me.PPiece_6.Tag = "6"
        Me.ToolTip1.SetToolTip(Me.PPiece_6, "6")
        '
        'PPiece_5
        '
        Me.PPiece_5.BackColor = System.Drawing.Color.Transparent
        Me.PPiece_5.Cursor = System.Windows.Forms.Cursors.Default
        Me.PPiece_5.Image = CType(resources.GetObject("PPiece_5.Image"), System.Drawing.Image)
        Me.PPiece.SetIndex(Me.PPiece_5, CType(5, Short))
        Me.PPiece_5.Location = New System.Drawing.Point(168, 96)
        Me.PPiece_5.Name = "PPiece_5"
        Me.PPiece_5.Size = New System.Drawing.Size(30, 30)
        Me.PPiece_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PPiece_5.TabIndex = 20
        Me.PPiece_5.TabStop = False
        Me.PPiece_5.Tag = "5"
        Me.ToolTip1.SetToolTip(Me.PPiece_5, "5")
        '
        'PPiece_4
        '
        Me.PPiece_4.BackColor = System.Drawing.Color.Transparent
        Me.PPiece_4.Cursor = System.Windows.Forms.Cursors.Default
        Me.PPiece_4.Image = CType(resources.GetObject("PPiece_4.Image"), System.Drawing.Image)
        Me.PPiece.SetIndex(Me.PPiece_4, CType(4, Short))
        Me.PPiece_4.Location = New System.Drawing.Point(136, 96)
        Me.PPiece_4.Name = "PPiece_4"
        Me.PPiece_4.Size = New System.Drawing.Size(30, 30)
        Me.PPiece_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PPiece_4.TabIndex = 21
        Me.PPiece_4.TabStop = False
        Me.PPiece_4.Tag = "4"
        Me.ToolTip1.SetToolTip(Me.PPiece_4, "4")
        '
        'PPiece_3
        '
        Me.PPiece_3.BackColor = System.Drawing.Color.Transparent
        Me.PPiece_3.Cursor = System.Windows.Forms.Cursors.Default
        Me.PPiece_3.Image = CType(resources.GetObject("PPiece_3.Image"), System.Drawing.Image)
        Me.PPiece.SetIndex(Me.PPiece_3, CType(3, Short))
        Me.PPiece_3.Location = New System.Drawing.Point(104, 96)
        Me.PPiece_3.Name = "PPiece_3"
        Me.PPiece_3.Size = New System.Drawing.Size(30, 30)
        Me.PPiece_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PPiece_3.TabIndex = 22
        Me.PPiece_3.TabStop = False
        Me.PPiece_3.Tag = "3"
        Me.ToolTip1.SetToolTip(Me.PPiece_3, "3")
        '
        'PPiece_2
        '
        Me.PPiece_2.BackColor = System.Drawing.Color.Transparent
        Me.PPiece_2.Cursor = System.Windows.Forms.Cursors.Default
        Me.PPiece_2.Image = CType(resources.GetObject("PPiece_2.Image"), System.Drawing.Image)
        Me.PPiece.SetIndex(Me.PPiece_2, CType(2, Short))
        Me.PPiece_2.Location = New System.Drawing.Point(72, 96)
        Me.PPiece_2.Name = "PPiece_2"
        Me.PPiece_2.Size = New System.Drawing.Size(30, 30)
        Me.PPiece_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PPiece_2.TabIndex = 23
        Me.PPiece_2.TabStop = False
        Me.PPiece_2.Tag = "2"
        Me.ToolTip1.SetToolTip(Me.PPiece_2, "2")
        '
        'PPiece_1
        '
        Me.PPiece_1.BackColor = System.Drawing.Color.Transparent
        Me.PPiece_1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PPiece_1.Image = CType(resources.GetObject("PPiece_1.Image"), System.Drawing.Image)
        Me.PPiece.SetIndex(Me.PPiece_1, CType(1, Short))
        Me.PPiece_1.Location = New System.Drawing.Point(40, 96)
        Me.PPiece_1.Name = "PPiece_1"
        Me.PPiece_1.Size = New System.Drawing.Size(30, 30)
        Me.PPiece_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PPiece_1.TabIndex = 24
        Me.PPiece_1.TabStop = False
        Me.PPiece_1.Tag = "1"
        Me.ToolTip1.SetToolTip(Me.PPiece_1, "1")
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
        'PPiece_24
        '
        Me.PPiece_24.BackColor = System.Drawing.Color.Transparent
        Me.PPiece_24.Cursor = System.Windows.Forms.Cursors.Default
        Me.PPiece_24.Image = CType(resources.GetObject("PPiece_24.Image"), System.Drawing.Image)
        Me.PPiece.SetIndex(Me.PPiece_24, CType(24, Short))
        Me.PPiece_24.Location = New System.Drawing.Point(200, 0)
        Me.PPiece_24.Name = "PPiece_24"
        Me.PPiece_24.Size = New System.Drawing.Size(30, 30)
        Me.PPiece_24.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PPiece_24.TabIndex = 1
        Me.PPiece_24.TabStop = False
        Me.PPiece_24.Tag = "24"
        '
        'PPiece_23
        '
        Me.PPiece_23.BackColor = System.Drawing.Color.Transparent
        Me.PPiece_23.Cursor = System.Windows.Forms.Cursors.Default
        Me.PPiece_23.Image = CType(resources.GetObject("PPiece_23.Image"), System.Drawing.Image)
        Me.PPiece.SetIndex(Me.PPiece_23, CType(23, Short))
        Me.PPiece_23.Location = New System.Drawing.Point(168, 0)
        Me.PPiece_23.Name = "PPiece_23"
        Me.PPiece_23.Size = New System.Drawing.Size(30, 30)
        Me.PPiece_23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PPiece_23.TabIndex = 2
        Me.PPiece_23.TabStop = False
        Me.PPiece_23.Tag = "23"
        '
        'PPiece_22
        '
        Me.PPiece_22.BackColor = System.Drawing.Color.Transparent
        Me.PPiece_22.Cursor = System.Windows.Forms.Cursors.Default
        Me.PPiece_22.Image = CType(resources.GetObject("PPiece_22.Image"), System.Drawing.Image)
        Me.PPiece.SetIndex(Me.PPiece_22, CType(22, Short))
        Me.PPiece_22.Location = New System.Drawing.Point(136, 0)
        Me.PPiece_22.Name = "PPiece_22"
        Me.PPiece_22.Size = New System.Drawing.Size(30, 30)
        Me.PPiece_22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PPiece_22.TabIndex = 3
        Me.PPiece_22.TabStop = False
        Me.PPiece_22.Tag = "22"
        '
        'PPiece_21
        '
        Me.PPiece_21.BackColor = System.Drawing.Color.Transparent
        Me.PPiece_21.Cursor = System.Windows.Forms.Cursors.Default
        Me.PPiece_21.Image = CType(resources.GetObject("PPiece_21.Image"), System.Drawing.Image)
        Me.PPiece.SetIndex(Me.PPiece_21, CType(21, Short))
        Me.PPiece_21.Location = New System.Drawing.Point(104, 0)
        Me.PPiece_21.Name = "PPiece_21"
        Me.PPiece_21.Size = New System.Drawing.Size(30, 30)
        Me.PPiece_21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PPiece_21.TabIndex = 4
        Me.PPiece_21.TabStop = False
        Me.PPiece_21.Tag = "21"
        '
        'PPiece_20
        '
        Me.PPiece_20.BackColor = System.Drawing.Color.Transparent
        Me.PPiece_20.Cursor = System.Windows.Forms.Cursors.Default
        Me.PPiece_20.Image = CType(resources.GetObject("PPiece_20.Image"), System.Drawing.Image)
        Me.PPiece.SetIndex(Me.PPiece_20, CType(20, Short))
        Me.PPiece_20.Location = New System.Drawing.Point(40, 0)
        Me.PPiece_20.Name = "PPiece_20"
        Me.PPiece_20.Size = New System.Drawing.Size(30, 30)
        Me.PPiece_20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PPiece_20.TabIndex = 5
        Me.PPiece_20.TabStop = False
        Me.PPiece_20.Tag = "20"
        '
        'PPiece_19
        '
        Me.PPiece_19.BackColor = System.Drawing.Color.Transparent
        Me.PPiece_19.Cursor = System.Windows.Forms.Cursors.Default
        Me.PPiece_19.Image = CType(resources.GetObject("PPiece_19.Image"), System.Drawing.Image)
        Me.PPiece.SetIndex(Me.PPiece_19, CType(19, Short))
        Me.PPiece_19.Location = New System.Drawing.Point(72, 0)
        Me.PPiece_19.Name = "PPiece_19"
        Me.PPiece_19.Size = New System.Drawing.Size(30, 30)
        Me.PPiece_19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PPiece_19.TabIndex = 6
        Me.PPiece_19.TabStop = False
        Me.PPiece_19.Tag = "19"
        '
        'PPiece_18
        '
        Me.PPiece_18.BackColor = System.Drawing.Color.Transparent
        Me.PPiece_18.Cursor = System.Windows.Forms.Cursors.Default
        Me.PPiece_18.Image = CType(resources.GetObject("PPiece_18.Image"), System.Drawing.Image)
        Me.PPiece.SetIndex(Me.PPiece_18, CType(18, Short))
        Me.PPiece_18.Location = New System.Drawing.Point(200, 32)
        Me.PPiece_18.Name = "PPiece_18"
        Me.PPiece_18.Size = New System.Drawing.Size(30, 30)
        Me.PPiece_18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PPiece_18.TabIndex = 7
        Me.PPiece_18.TabStop = False
        Me.PPiece_18.Tag = "18"
        '
        'PPiece_17
        '
        Me.PPiece_17.BackColor = System.Drawing.Color.Transparent
        Me.PPiece_17.Cursor = System.Windows.Forms.Cursors.Default
        Me.PPiece_17.Image = CType(resources.GetObject("PPiece_17.Image"), System.Drawing.Image)
        Me.PPiece.SetIndex(Me.PPiece_17, CType(17, Short))
        Me.PPiece_17.Location = New System.Drawing.Point(168, 32)
        Me.PPiece_17.Name = "PPiece_17"
        Me.PPiece_17.Size = New System.Drawing.Size(30, 30)
        Me.PPiece_17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PPiece_17.TabIndex = 8
        Me.PPiece_17.TabStop = False
        Me.PPiece_17.Tag = "17"
        '
        'PPiece_16
        '
        Me.PPiece_16.BackColor = System.Drawing.Color.Transparent
        Me.PPiece_16.Cursor = System.Windows.Forms.Cursors.Default
        Me.PPiece_16.Image = CType(resources.GetObject("PPiece_16.Image"), System.Drawing.Image)
        Me.PPiece.SetIndex(Me.PPiece_16, CType(16, Short))
        Me.PPiece_16.Location = New System.Drawing.Point(136, 32)
        Me.PPiece_16.Name = "PPiece_16"
        Me.PPiece_16.Size = New System.Drawing.Size(30, 30)
        Me.PPiece_16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PPiece_16.TabIndex = 9
        Me.PPiece_16.TabStop = False
        Me.PPiece_16.Tag = "16"
        '
        'PPiece_15
        '
        Me.PPiece_15.BackColor = System.Drawing.Color.Transparent
        Me.PPiece_15.Cursor = System.Windows.Forms.Cursors.Default
        Me.PPiece_15.Image = CType(resources.GetObject("PPiece_15.Image"), System.Drawing.Image)
        Me.PPiece.SetIndex(Me.PPiece_15, CType(15, Short))
        Me.PPiece_15.Location = New System.Drawing.Point(104, 32)
        Me.PPiece_15.Name = "PPiece_15"
        Me.PPiece_15.Size = New System.Drawing.Size(30, 30)
        Me.PPiece_15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PPiece_15.TabIndex = 10
        Me.PPiece_15.TabStop = False
        Me.PPiece_15.Tag = "15"
        '
        'PPiece_14
        '
        Me.PPiece_14.BackColor = System.Drawing.Color.Transparent
        Me.PPiece_14.Cursor = System.Windows.Forms.Cursors.Default
        Me.PPiece_14.Image = CType(resources.GetObject("PPiece_14.Image"), System.Drawing.Image)
        Me.PPiece.SetIndex(Me.PPiece_14, CType(14, Short))
        Me.PPiece_14.Location = New System.Drawing.Point(72, 32)
        Me.PPiece_14.Name = "PPiece_14"
        Me.PPiece_14.Size = New System.Drawing.Size(30, 30)
        Me.PPiece_14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PPiece_14.TabIndex = 11
        Me.PPiece_14.TabStop = False
        Me.PPiece_14.Tag = "14"
        '
        'PPiece_13
        '
        Me.PPiece_13.BackColor = System.Drawing.Color.Transparent
        Me.PPiece_13.Cursor = System.Windows.Forms.Cursors.Default
        Me.PPiece_13.Image = CType(resources.GetObject("PPiece_13.Image"), System.Drawing.Image)
        Me.PPiece.SetIndex(Me.PPiece_13, CType(13, Short))
        Me.PPiece_13.Location = New System.Drawing.Point(40, 32)
        Me.PPiece_13.Name = "PPiece_13"
        Me.PPiece_13.Size = New System.Drawing.Size(30, 30)
        Me.PPiece_13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PPiece_13.TabIndex = 12
        Me.PPiece_13.TabStop = False
        Me.PPiece_13.Tag = "13"
        '
        'PPiece_12
        '
        Me.PPiece_12.BackColor = System.Drawing.Color.Transparent
        Me.PPiece_12.Cursor = System.Windows.Forms.Cursors.Default
        Me.PPiece_12.Image = CType(resources.GetObject("PPiece_12.Image"), System.Drawing.Image)
        Me.PPiece.SetIndex(Me.PPiece_12, CType(12, Short))
        Me.PPiece_12.Location = New System.Drawing.Point(200, 64)
        Me.PPiece_12.Name = "PPiece_12"
        Me.PPiece_12.Size = New System.Drawing.Size(30, 30)
        Me.PPiece_12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PPiece_12.TabIndex = 13
        Me.PPiece_12.TabStop = False
        Me.PPiece_12.Tag = "12"
        '
        'PPiece_11
        '
        Me.PPiece_11.BackColor = System.Drawing.Color.Transparent
        Me.PPiece_11.Cursor = System.Windows.Forms.Cursors.Default
        Me.PPiece_11.Image = CType(resources.GetObject("PPiece_11.Image"), System.Drawing.Image)
        Me.PPiece.SetIndex(Me.PPiece_11, CType(11, Short))
        Me.PPiece_11.Location = New System.Drawing.Point(168, 64)
        Me.PPiece_11.Name = "PPiece_11"
        Me.PPiece_11.Size = New System.Drawing.Size(30, 30)
        Me.PPiece_11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PPiece_11.TabIndex = 14
        Me.PPiece_11.TabStop = False
        Me.PPiece_11.Tag = "11"
        '
        'PPiece_10
        '
        Me.PPiece_10.BackColor = System.Drawing.Color.Transparent
        Me.PPiece_10.Cursor = System.Windows.Forms.Cursors.Default
        Me.PPiece_10.Image = CType(resources.GetObject("PPiece_10.Image"), System.Drawing.Image)
        Me.PPiece.SetIndex(Me.PPiece_10, CType(10, Short))
        Me.PPiece_10.Location = New System.Drawing.Point(136, 64)
        Me.PPiece_10.Name = "PPiece_10"
        Me.PPiece_10.Size = New System.Drawing.Size(30, 30)
        Me.PPiece_10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PPiece_10.TabIndex = 15
        Me.PPiece_10.TabStop = False
        Me.PPiece_10.Tag = "10"
        '
        'PPiece_9
        '
        Me.PPiece_9.BackColor = System.Drawing.Color.Transparent
        Me.PPiece_9.Cursor = System.Windows.Forms.Cursors.Default
        Me.PPiece_9.Image = CType(resources.GetObject("PPiece_9.Image"), System.Drawing.Image)
        Me.PPiece.SetIndex(Me.PPiece_9, CType(9, Short))
        Me.PPiece_9.Location = New System.Drawing.Point(104, 64)
        Me.PPiece_9.Name = "PPiece_9"
        Me.PPiece_9.Size = New System.Drawing.Size(30, 30)
        Me.PPiece_9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PPiece_9.TabIndex = 16
        Me.PPiece_9.TabStop = False
        Me.PPiece_9.Tag = "9"
        '
        'PPiece_8
        '
        Me.PPiece_8.BackColor = System.Drawing.Color.Transparent
        Me.PPiece_8.Cursor = System.Windows.Forms.Cursors.Default
        Me.PPiece_8.Image = CType(resources.GetObject("PPiece_8.Image"), System.Drawing.Image)
        Me.PPiece.SetIndex(Me.PPiece_8, CType(8, Short))
        Me.PPiece_8.Location = New System.Drawing.Point(72, 64)
        Me.PPiece_8.Name = "PPiece_8"
        Me.PPiece_8.Size = New System.Drawing.Size(30, 30)
        Me.PPiece_8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PPiece_8.TabIndex = 17
        Me.PPiece_8.TabStop = False
        Me.PPiece_8.Tag = "8"
        '
        'PPiece_7
        '
        Me.PPiece_7.BackColor = System.Drawing.Color.Transparent
        Me.PPiece_7.Cursor = System.Windows.Forms.Cursors.Default
        Me.PPiece_7.Image = CType(resources.GetObject("PPiece_7.Image"), System.Drawing.Image)
        Me.PPiece.SetIndex(Me.PPiece_7, CType(7, Short))
        Me.PPiece_7.Location = New System.Drawing.Point(40, 64)
        Me.PPiece_7.Name = "PPiece_7"
        Me.PPiece_7.Size = New System.Drawing.Size(30, 30)
        Me.PPiece_7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PPiece_7.TabIndex = 18
        Me.PPiece_7.TabStop = False
        Me.PPiece_7.Tag = "7"
        '
        'Segment_96
        '
        Me.Segment_96.BackColor = System.Drawing.Color.Transparent
        Me.Segment_96.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_96.Image = CType(resources.GetObject("Segment_96.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_96, CType(96, Short))
        Me.Segment_96.Location = New System.Drawing.Point(432, 160)
        Me.Segment_96.Name = "Segment_96"
        Me.Segment_96.Size = New System.Drawing.Size(30, 30)
        Me.Segment_96.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_96.TabIndex = 25
        Me.Segment_96.TabStop = False
        '
        'Segment_95
        '
        Me.Segment_95.BackColor = System.Drawing.Color.Transparent
        Me.Segment_95.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_95.Image = CType(resources.GetObject("Segment_95.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_95, CType(95, Short))
        Me.Segment_95.Location = New System.Drawing.Point(304, 192)
        Me.Segment_95.Name = "Segment_95"
        Me.Segment_95.Size = New System.Drawing.Size(30, 30)
        Me.Segment_95.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_95.TabIndex = 26
        Me.Segment_95.TabStop = False
        '
        'Segment_94
        '
        Me.Segment_94.BackColor = System.Drawing.Color.Transparent
        Me.Segment_94.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_94.Image = CType(resources.GetObject("Segment_94.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_94, CType(94, Short))
        Me.Segment_94.Location = New System.Drawing.Point(240, 96)
        Me.Segment_94.Name = "Segment_94"
        Me.Segment_94.Size = New System.Drawing.Size(30, 30)
        Me.Segment_94.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_94.TabIndex = 27
        Me.Segment_94.TabStop = False
        '
        'Segment_93
        '
        Me.Segment_93.BackColor = System.Drawing.Color.Transparent
        Me.Segment_93.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_93.Image = CType(resources.GetObject("Segment_93.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_93, CType(93, Short))
        Me.Segment_93.Location = New System.Drawing.Point(272, 96)
        Me.Segment_93.Name = "Segment_93"
        Me.Segment_93.Size = New System.Drawing.Size(30, 30)
        Me.Segment_93.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_93.TabIndex = 28
        Me.Segment_93.TabStop = False
        '
        'Segment_92
        '
        Me.Segment_92.BackColor = System.Drawing.Color.Transparent
        Me.Segment_92.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_92.Image = CType(resources.GetObject("Segment_92.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_92, CType(92, Short))
        Me.Segment_92.Location = New System.Drawing.Point(304, 96)
        Me.Segment_92.Name = "Segment_92"
        Me.Segment_92.Size = New System.Drawing.Size(30, 30)
        Me.Segment_92.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_92.TabIndex = 29
        Me.Segment_92.TabStop = False
        '
        'Segment_91
        '
        Me.Segment_91.BackColor = System.Drawing.Color.Transparent
        Me.Segment_91.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_91.Image = CType(resources.GetObject("Segment_91.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_91, CType(91, Short))
        Me.Segment_91.Location = New System.Drawing.Point(336, 96)
        Me.Segment_91.Name = "Segment_91"
        Me.Segment_91.Size = New System.Drawing.Size(30, 30)
        Me.Segment_91.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_91.TabIndex = 30
        Me.Segment_91.TabStop = False
        '
        'Segment_90
        '
        Me.Segment_90.BackColor = System.Drawing.Color.Transparent
        Me.Segment_90.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_90.Image = CType(resources.GetObject("Segment_90.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_90, CType(90, Short))
        Me.Segment_90.Location = New System.Drawing.Point(368, 96)
        Me.Segment_90.Name = "Segment_90"
        Me.Segment_90.Size = New System.Drawing.Size(30, 30)
        Me.Segment_90.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_90.TabIndex = 31
        Me.Segment_90.TabStop = False
        '
        'Segment_89
        '
        Me.Segment_89.BackColor = System.Drawing.Color.Transparent
        Me.Segment_89.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_89.Image = CType(resources.GetObject("Segment_89.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_89, CType(89, Short))
        Me.Segment_89.Location = New System.Drawing.Point(240, 128)
        Me.Segment_89.Name = "Segment_89"
        Me.Segment_89.Size = New System.Drawing.Size(30, 30)
        Me.Segment_89.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_89.TabIndex = 32
        Me.Segment_89.TabStop = False
        '
        'Segment_88
        '
        Me.Segment_88.BackColor = System.Drawing.Color.Transparent
        Me.Segment_88.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_88.Image = CType(resources.GetObject("Segment_88.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_88, CType(88, Short))
        Me.Segment_88.Location = New System.Drawing.Point(272, 128)
        Me.Segment_88.Name = "Segment_88"
        Me.Segment_88.Size = New System.Drawing.Size(30, 30)
        Me.Segment_88.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_88.TabIndex = 33
        Me.Segment_88.TabStop = False
        '
        'Segment_87
        '
        Me.Segment_87.BackColor = System.Drawing.Color.Transparent
        Me.Segment_87.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_87.Image = CType(resources.GetObject("Segment_87.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_87, CType(87, Short))
        Me.Segment_87.Location = New System.Drawing.Point(304, 128)
        Me.Segment_87.Name = "Segment_87"
        Me.Segment_87.Size = New System.Drawing.Size(30, 30)
        Me.Segment_87.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_87.TabIndex = 34
        Me.Segment_87.TabStop = False
        '
        'Segment_86
        '
        Me.Segment_86.BackColor = System.Drawing.Color.Transparent
        Me.Segment_86.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_86.Image = CType(resources.GetObject("Segment_86.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_86, CType(86, Short))
        Me.Segment_86.Location = New System.Drawing.Point(336, 128)
        Me.Segment_86.Name = "Segment_86"
        Me.Segment_86.Size = New System.Drawing.Size(30, 30)
        Me.Segment_86.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_86.TabIndex = 35
        Me.Segment_86.TabStop = False
        '
        'Segment_85
        '
        Me.Segment_85.BackColor = System.Drawing.Color.Transparent
        Me.Segment_85.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_85.Image = CType(resources.GetObject("Segment_85.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_85, CType(85, Short))
        Me.Segment_85.Location = New System.Drawing.Point(368, 128)
        Me.Segment_85.Name = "Segment_85"
        Me.Segment_85.Size = New System.Drawing.Size(30, 30)
        Me.Segment_85.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_85.TabIndex = 36
        Me.Segment_85.TabStop = False
        '
        'Segment_84
        '
        Me.Segment_84.BackColor = System.Drawing.Color.Transparent
        Me.Segment_84.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_84.Image = CType(resources.GetObject("Segment_84.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_84, CType(84, Short))
        Me.Segment_84.Location = New System.Drawing.Point(240, 160)
        Me.Segment_84.Name = "Segment_84"
        Me.Segment_84.Size = New System.Drawing.Size(30, 30)
        Me.Segment_84.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_84.TabIndex = 37
        Me.Segment_84.TabStop = False
        '
        'Segment_83
        '
        Me.Segment_83.BackColor = System.Drawing.Color.Transparent
        Me.Segment_83.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_83.Image = CType(resources.GetObject("Segment_83.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_83, CType(83, Short))
        Me.Segment_83.Location = New System.Drawing.Point(272, 160)
        Me.Segment_83.Name = "Segment_83"
        Me.Segment_83.Size = New System.Drawing.Size(30, 30)
        Me.Segment_83.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_83.TabIndex = 38
        Me.Segment_83.TabStop = False
        '
        'Segment_82
        '
        Me.Segment_82.BackColor = System.Drawing.Color.Transparent
        Me.Segment_82.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_82.Image = CType(resources.GetObject("Segment_82.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_82, CType(82, Short))
        Me.Segment_82.Location = New System.Drawing.Point(304, 160)
        Me.Segment_82.Name = "Segment_82"
        Me.Segment_82.Size = New System.Drawing.Size(30, 30)
        Me.Segment_82.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_82.TabIndex = 39
        Me.Segment_82.TabStop = False
        '
        'Segment_81
        '
        Me.Segment_81.BackColor = System.Drawing.Color.Transparent
        Me.Segment_81.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_81.Image = CType(resources.GetObject("Segment_81.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_81, CType(81, Short))
        Me.Segment_81.Location = New System.Drawing.Point(336, 160)
        Me.Segment_81.Name = "Segment_81"
        Me.Segment_81.Size = New System.Drawing.Size(30, 30)
        Me.Segment_81.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_81.TabIndex = 40
        Me.Segment_81.TabStop = False
        '
        'Segment_80
        '
        Me.Segment_80.BackColor = System.Drawing.Color.Transparent
        Me.Segment_80.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_80.Image = CType(resources.GetObject("Segment_80.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_80, CType(80, Short))
        Me.Segment_80.Location = New System.Drawing.Point(368, 160)
        Me.Segment_80.Name = "Segment_80"
        Me.Segment_80.Size = New System.Drawing.Size(30, 30)
        Me.Segment_80.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_80.TabIndex = 41
        Me.Segment_80.TabStop = False
        '
        'Segment_79
        '
        Me.Segment_79.BackColor = System.Drawing.Color.Transparent
        Me.Segment_79.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_79.Image = CType(resources.GetObject("Segment_79.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_79, CType(79, Short))
        Me.Segment_79.Location = New System.Drawing.Point(400, 160)
        Me.Segment_79.Name = "Segment_79"
        Me.Segment_79.Size = New System.Drawing.Size(30, 30)
        Me.Segment_79.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_79.TabIndex = 42
        Me.Segment_79.TabStop = False
        '
        'Segment_78
        '
        Me.Segment_78.BackColor = System.Drawing.Color.Transparent
        Me.Segment_78.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_78.Image = CType(resources.GetObject("Segment_78.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_78, CType(78, Short))
        Me.Segment_78.Location = New System.Drawing.Point(240, 192)
        Me.Segment_78.Name = "Segment_78"
        Me.Segment_78.Size = New System.Drawing.Size(30, 30)
        Me.Segment_78.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_78.TabIndex = 43
        Me.Segment_78.TabStop = False
        '
        'Segment_77
        '
        Me.Segment_77.BackColor = System.Drawing.Color.Transparent
        Me.Segment_77.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_77.Image = CType(resources.GetObject("Segment_77.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_77, CType(77, Short))
        Me.Segment_77.Location = New System.Drawing.Point(400, 96)
        Me.Segment_77.Name = "Segment_77"
        Me.Segment_77.Size = New System.Drawing.Size(30, 30)
        Me.Segment_77.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_77.TabIndex = 44
        Me.Segment_77.TabStop = False
        '
        'Segment_76
        '
        Me.Segment_76.BackColor = System.Drawing.Color.Transparent
        Me.Segment_76.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_76.Image = CType(resources.GetObject("Segment_76.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_76, CType(76, Short))
        Me.Segment_76.Location = New System.Drawing.Point(432, 96)
        Me.Segment_76.Name = "Segment_76"
        Me.Segment_76.Size = New System.Drawing.Size(30, 30)
        Me.Segment_76.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_76.TabIndex = 45
        Me.Segment_76.TabStop = False
        '
        'Segment_75
        '
        Me.Segment_75.BackColor = System.Drawing.Color.Transparent
        Me.Segment_75.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_75.Image = CType(resources.GetObject("Segment_75.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_75, CType(75, Short))
        Me.Segment_75.Location = New System.Drawing.Point(464, 96)
        Me.Segment_75.Name = "Segment_75"
        Me.Segment_75.Size = New System.Drawing.Size(30, 30)
        Me.Segment_75.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_75.TabIndex = 46
        Me.Segment_75.TabStop = False
        '
        'Segment_74
        '
        Me.Segment_74.BackColor = System.Drawing.Color.Transparent
        Me.Segment_74.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_74.Image = CType(resources.GetObject("Segment_74.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_74, CType(74, Short))
        Me.Segment_74.Location = New System.Drawing.Point(400, 128)
        Me.Segment_74.Name = "Segment_74"
        Me.Segment_74.Size = New System.Drawing.Size(30, 30)
        Me.Segment_74.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_74.TabIndex = 47
        Me.Segment_74.TabStop = False
        '
        'Segment_73
        '
        Me.Segment_73.BackColor = System.Drawing.Color.Transparent
        Me.Segment_73.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_73.Image = CType(resources.GetObject("Segment_73.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_73, CType(73, Short))
        Me.Segment_73.Location = New System.Drawing.Point(432, 128)
        Me.Segment_73.Name = "Segment_73"
        Me.Segment_73.Size = New System.Drawing.Size(30, 30)
        Me.Segment_73.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_73.TabIndex = 48
        Me.Segment_73.TabStop = False
        '
        'Segment_72
        '
        Me.Segment_72.BackColor = System.Drawing.Color.Transparent
        Me.Segment_72.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_72.Image = CType(resources.GetObject("Segment_72.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_72, CType(72, Short))
        Me.Segment_72.Location = New System.Drawing.Point(464, 128)
        Me.Segment_72.Name = "Segment_72"
        Me.Segment_72.Size = New System.Drawing.Size(30, 30)
        Me.Segment_72.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_72.TabIndex = 49
        Me.Segment_72.TabStop = False
        '
        'Segment_71
        '
        Me.Segment_71.BackColor = System.Drawing.Color.Transparent
        Me.Segment_71.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_71.Image = CType(resources.GetObject("Segment_71.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_71, CType(71, Short))
        Me.Segment_71.Location = New System.Drawing.Point(464, 160)
        Me.Segment_71.Name = "Segment_71"
        Me.Segment_71.Size = New System.Drawing.Size(30, 30)
        Me.Segment_71.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_71.TabIndex = 50
        Me.Segment_71.TabStop = False
        '
        'Segment_70
        '
        Me.Segment_70.BackColor = System.Drawing.Color.Transparent
        Me.Segment_70.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_70.Image = CType(resources.GetObject("Segment_70.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_70, CType(70, Short))
        Me.Segment_70.Location = New System.Drawing.Point(272, 192)
        Me.Segment_70.Name = "Segment_70"
        Me.Segment_70.Size = New System.Drawing.Size(30, 30)
        Me.Segment_70.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_70.TabIndex = 51
        Me.Segment_70.TabStop = False
        '
        'Segment_69
        '
        Me.Segment_69.BackColor = System.Drawing.Color.Transparent
        Me.Segment_69.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_69.Image = CType(resources.GetObject("Segment_69.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_69, CType(69, Short))
        Me.Segment_69.Location = New System.Drawing.Point(336, 192)
        Me.Segment_69.Name = "Segment_69"
        Me.Segment_69.Size = New System.Drawing.Size(30, 30)
        Me.Segment_69.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_69.TabIndex = 52
        Me.Segment_69.TabStop = False
        '
        'Segment_68
        '
        Me.Segment_68.BackColor = System.Drawing.Color.Transparent
        Me.Segment_68.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_68.Image = CType(resources.GetObject("Segment_68.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_68, CType(68, Short))
        Me.Segment_68.Location = New System.Drawing.Point(368, 192)
        Me.Segment_68.Name = "Segment_68"
        Me.Segment_68.Size = New System.Drawing.Size(30, 30)
        Me.Segment_68.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_68.TabIndex = 53
        Me.Segment_68.TabStop = False
        '
        'Segment_67
        '
        Me.Segment_67.BackColor = System.Drawing.Color.Transparent
        Me.Segment_67.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_67.Image = CType(resources.GetObject("Segment_67.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_67, CType(67, Short))
        Me.Segment_67.Location = New System.Drawing.Point(400, 192)
        Me.Segment_67.Name = "Segment_67"
        Me.Segment_67.Size = New System.Drawing.Size(30, 30)
        Me.Segment_67.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_67.TabIndex = 54
        Me.Segment_67.TabStop = False
        '
        'Segment_66
        '
        Me.Segment_66.BackColor = System.Drawing.Color.Transparent
        Me.Segment_66.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_66.Image = CType(resources.GetObject("Segment_66.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_66, CType(66, Short))
        Me.Segment_66.Location = New System.Drawing.Point(432, 192)
        Me.Segment_66.Name = "Segment_66"
        Me.Segment_66.Size = New System.Drawing.Size(30, 30)
        Me.Segment_66.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_66.TabIndex = 55
        Me.Segment_66.TabStop = False
        '
        'Segment_65
        '
        Me.Segment_65.BackColor = System.Drawing.Color.Transparent
        Me.Segment_65.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_65.Image = CType(resources.GetObject("Segment_65.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_65, CType(65, Short))
        Me.Segment_65.Location = New System.Drawing.Point(464, 192)
        Me.Segment_65.Name = "Segment_65"
        Me.Segment_65.Size = New System.Drawing.Size(30, 30)
        Me.Segment_65.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_65.TabIndex = 56
        Me.Segment_65.TabStop = False
        '
        'Segment_64
        '
        Me.Segment_64.BackColor = System.Drawing.Color.Transparent
        Me.Segment_64.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_64.Image = CType(resources.GetObject("Segment_64.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_64, CType(64, Short))
        Me.Segment_64.Location = New System.Drawing.Point(200, 128)
        Me.Segment_64.Name = "Segment_64"
        Me.Segment_64.Size = New System.Drawing.Size(30, 30)
        Me.Segment_64.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_64.TabIndex = 57
        Me.Segment_64.TabStop = False
        '
        'Segment_63
        '
        Me.Segment_63.BackColor = System.Drawing.Color.Transparent
        Me.Segment_63.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_63.Image = CType(resources.GetObject("Segment_63.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_63, CType(63, Short))
        Me.Segment_63.Location = New System.Drawing.Point(144, 128)
        Me.Segment_63.Name = "Segment_63"
        Me.Segment_63.Size = New System.Drawing.Size(30, 30)
        Me.Segment_63.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_63.TabIndex = 58
        Me.Segment_63.TabStop = False
        '
        'Segment_62
        '
        Me.Segment_62.BackColor = System.Drawing.Color.Transparent
        Me.Segment_62.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_62.Image = CType(resources.GetObject("Segment_62.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_62, CType(62, Short))
        Me.Segment_62.Location = New System.Drawing.Point(120, 128)
        Me.Segment_62.Name = "Segment_62"
        Me.Segment_62.Size = New System.Drawing.Size(30, 30)
        Me.Segment_62.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_62.TabIndex = 59
        Me.Segment_62.TabStop = False
        '
        'Segment_61
        '
        Me.Segment_61.BackColor = System.Drawing.Color.Transparent
        Me.Segment_61.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_61.Image = CType(resources.GetObject("Segment_61.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_61, CType(61, Short))
        Me.Segment_61.Location = New System.Drawing.Point(88, 128)
        Me.Segment_61.Name = "Segment_61"
        Me.Segment_61.Size = New System.Drawing.Size(30, 30)
        Me.Segment_61.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_61.TabIndex = 60
        Me.Segment_61.TabStop = False
        '
        'Segment_60
        '
        Me.Segment_60.BackColor = System.Drawing.Color.Transparent
        Me.Segment_60.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_60.Image = CType(resources.GetObject("Segment_60.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_60, CType(60, Short))
        Me.Segment_60.Location = New System.Drawing.Point(64, 128)
        Me.Segment_60.Name = "Segment_60"
        Me.Segment_60.Size = New System.Drawing.Size(30, 30)
        Me.Segment_60.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_60.TabIndex = 61
        Me.Segment_60.TabStop = False
        '
        'Segment_59
        '
        Me.Segment_59.BackColor = System.Drawing.Color.Transparent
        Me.Segment_59.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_59.Image = CType(resources.GetObject("Segment_59.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_59, CType(59, Short))
        Me.Segment_59.Location = New System.Drawing.Point(32, 128)
        Me.Segment_59.Name = "Segment_59"
        Me.Segment_59.Size = New System.Drawing.Size(30, 30)
        Me.Segment_59.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_59.TabIndex = 62
        Me.Segment_59.TabStop = False
        '
        'Segment_58
        '
        Me.Segment_58.BackColor = System.Drawing.Color.Transparent
        Me.Segment_58.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_58.Image = CType(resources.GetObject("Segment_58.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_58, CType(58, Short))
        Me.Segment_58.Location = New System.Drawing.Point(8, 128)
        Me.Segment_58.Name = "Segment_58"
        Me.Segment_58.Size = New System.Drawing.Size(30, 30)
        Me.Segment_58.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_58.TabIndex = 63
        Me.Segment_58.TabStop = False
        '
        'Segment_57
        '
        Me.Segment_57.BackColor = System.Drawing.Color.Transparent
        Me.Segment_57.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_57.Image = CType(resources.GetObject("Segment_57.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_57, CType(57, Short))
        Me.Segment_57.Location = New System.Drawing.Point(8, 160)
        Me.Segment_57.Name = "Segment_57"
        Me.Segment_57.Size = New System.Drawing.Size(30, 30)
        Me.Segment_57.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_57.TabIndex = 64
        Me.Segment_57.TabStop = False
        '
        'Segment_56
        '
        Me.Segment_56.BackColor = System.Drawing.Color.Transparent
        Me.Segment_56.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_56.Image = CType(resources.GetObject("Segment_56.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_56, CType(56, Short))
        Me.Segment_56.Location = New System.Drawing.Point(32, 160)
        Me.Segment_56.Name = "Segment_56"
        Me.Segment_56.Size = New System.Drawing.Size(30, 30)
        Me.Segment_56.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_56.TabIndex = 65
        Me.Segment_56.TabStop = False
        '
        'Segment_55
        '
        Me.Segment_55.BackColor = System.Drawing.Color.Transparent
        Me.Segment_55.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_55.Image = CType(resources.GetObject("Segment_55.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_55, CType(55, Short))
        Me.Segment_55.Location = New System.Drawing.Point(64, 160)
        Me.Segment_55.Name = "Segment_55"
        Me.Segment_55.Size = New System.Drawing.Size(27, 30)
        Me.Segment_55.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_55.TabIndex = 66
        Me.Segment_55.TabStop = False
        '
        'Segment_54
        '
        Me.Segment_54.BackColor = System.Drawing.Color.Transparent
        Me.Segment_54.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_54.Image = CType(resources.GetObject("Segment_54.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_54, CType(54, Short))
        Me.Segment_54.Location = New System.Drawing.Point(88, 160)
        Me.Segment_54.Name = "Segment_54"
        Me.Segment_54.Size = New System.Drawing.Size(30, 30)
        Me.Segment_54.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_54.TabIndex = 67
        Me.Segment_54.TabStop = False
        '
        'Segment_53
        '
        Me.Segment_53.BackColor = System.Drawing.Color.Transparent
        Me.Segment_53.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_53.Image = CType(resources.GetObject("Segment_53.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_53, CType(53, Short))
        Me.Segment_53.Location = New System.Drawing.Point(120, 160)
        Me.Segment_53.Name = "Segment_53"
        Me.Segment_53.Size = New System.Drawing.Size(30, 30)
        Me.Segment_53.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_53.TabIndex = 68
        Me.Segment_53.TabStop = False
        '
        'Segment_52
        '
        Me.Segment_52.BackColor = System.Drawing.Color.Transparent
        Me.Segment_52.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_52.Image = CType(resources.GetObject("Segment_52.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_52, CType(52, Short))
        Me.Segment_52.Location = New System.Drawing.Point(144, 160)
        Me.Segment_52.Name = "Segment_52"
        Me.Segment_52.Size = New System.Drawing.Size(30, 30)
        Me.Segment_52.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_52.TabIndex = 69
        Me.Segment_52.TabStop = False
        '
        'Segment_51
        '
        Me.Segment_51.BackColor = System.Drawing.Color.Transparent
        Me.Segment_51.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_51.Image = CType(resources.GetObject("Segment_51.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_51, CType(51, Short))
        Me.Segment_51.Location = New System.Drawing.Point(176, 160)
        Me.Segment_51.Name = "Segment_51"
        Me.Segment_51.Size = New System.Drawing.Size(30, 30)
        Me.Segment_51.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_51.TabIndex = 70
        Me.Segment_51.TabStop = False
        '
        'Segment_50
        '
        Me.Segment_50.BackColor = System.Drawing.Color.Transparent
        Me.Segment_50.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_50.Image = CType(resources.GetObject("Segment_50.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_50, CType(50, Short))
        Me.Segment_50.Location = New System.Drawing.Point(200, 160)
        Me.Segment_50.Name = "Segment_50"
        Me.Segment_50.Size = New System.Drawing.Size(30, 30)
        Me.Segment_50.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_50.TabIndex = 71
        Me.Segment_50.TabStop = False
        '
        'Segment_49
        '
        Me.Segment_49.BackColor = System.Drawing.Color.Transparent
        Me.Segment_49.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_49.Image = CType(resources.GetObject("Segment_49.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_49, CType(49, Short))
        Me.Segment_49.Location = New System.Drawing.Point(8, 192)
        Me.Segment_49.Name = "Segment_49"
        Me.Segment_49.Size = New System.Drawing.Size(30, 30)
        Me.Segment_49.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_49.TabIndex = 72
        Me.Segment_49.TabStop = False
        '
        'Segment_48
        '
        Me.Segment_48.BackColor = System.Drawing.Color.Transparent
        Me.Segment_48.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_48.Image = CType(resources.GetObject("Segment_48.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_48, CType(48, Short))
        Me.Segment_48.Location = New System.Drawing.Point(32, 192)
        Me.Segment_48.Name = "Segment_48"
        Me.Segment_48.Size = New System.Drawing.Size(30, 30)
        Me.Segment_48.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_48.TabIndex = 73
        Me.Segment_48.TabStop = False
        '
        'Segment_47
        '
        Me.Segment_47.BackColor = System.Drawing.Color.Transparent
        Me.Segment_47.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_47.Image = CType(resources.GetObject("Segment_47.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_47, CType(47, Short))
        Me.Segment_47.Location = New System.Drawing.Point(64, 192)
        Me.Segment_47.Name = "Segment_47"
        Me.Segment_47.Size = New System.Drawing.Size(30, 30)
        Me.Segment_47.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_47.TabIndex = 74
        Me.Segment_47.TabStop = False
        '
        'Segment_46
        '
        Me.Segment_46.BackColor = System.Drawing.Color.Transparent
        Me.Segment_46.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_46.Image = CType(resources.GetObject("Segment_46.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_46, CType(46, Short))
        Me.Segment_46.Location = New System.Drawing.Point(200, 192)
        Me.Segment_46.Name = "Segment_46"
        Me.Segment_46.Size = New System.Drawing.Size(30, 30)
        Me.Segment_46.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_46.TabIndex = 75
        Me.Segment_46.TabStop = False
        '
        'Segment_45
        '
        Me.Segment_45.BackColor = System.Drawing.Color.Transparent
        Me.Segment_45.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_45.Image = CType(resources.GetObject("Segment_45.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_45, CType(45, Short))
        Me.Segment_45.Location = New System.Drawing.Point(176, 192)
        Me.Segment_45.Name = "Segment_45"
        Me.Segment_45.Size = New System.Drawing.Size(30, 30)
        Me.Segment_45.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_45.TabIndex = 76
        Me.Segment_45.TabStop = False
        '
        'Segment_44
        '
        Me.Segment_44.BackColor = System.Drawing.Color.Transparent
        Me.Segment_44.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_44.Image = CType(resources.GetObject("Segment_44.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_44, CType(44, Short))
        Me.Segment_44.Location = New System.Drawing.Point(144, 192)
        Me.Segment_44.Name = "Segment_44"
        Me.Segment_44.Size = New System.Drawing.Size(30, 30)
        Me.Segment_44.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_44.TabIndex = 77
        Me.Segment_44.TabStop = False
        '
        'Segment_43
        '
        Me.Segment_43.BackColor = System.Drawing.Color.Transparent
        Me.Segment_43.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_43.Image = CType(resources.GetObject("Segment_43.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_43, CType(43, Short))
        Me.Segment_43.Location = New System.Drawing.Point(120, 192)
        Me.Segment_43.Name = "Segment_43"
        Me.Segment_43.Size = New System.Drawing.Size(30, 30)
        Me.Segment_43.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_43.TabIndex = 78
        Me.Segment_43.TabStop = False
        '
        'Segment_42
        '
        Me.Segment_42.BackColor = System.Drawing.Color.Transparent
        Me.Segment_42.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_42.Image = CType(resources.GetObject("Segment_42.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_42, CType(42, Short))
        Me.Segment_42.Location = New System.Drawing.Point(88, 192)
        Me.Segment_42.Name = "Segment_42"
        Me.Segment_42.Size = New System.Drawing.Size(30, 30)
        Me.Segment_42.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_42.TabIndex = 79
        Me.Segment_42.TabStop = False
        '
        'Segment_41
        '
        Me.Segment_41.BackColor = System.Drawing.Color.Transparent
        Me.Segment_41.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_41.Image = CType(resources.GetObject("Segment_41.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_41, CType(41, Short))
        Me.Segment_41.Location = New System.Drawing.Point(176, 128)
        Me.Segment_41.Name = "Segment_41"
        Me.Segment_41.Size = New System.Drawing.Size(30, 30)
        Me.Segment_41.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_41.TabIndex = 80
        Me.Segment_41.TabStop = False
        '
        'Segment_40
        '
        Me.Segment_40.BackColor = System.Drawing.Color.Transparent
        Me.Segment_40.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_40.Image = CType(resources.GetObject("Segment_40.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_40, CType(40, Short))
        Me.Segment_40.Location = New System.Drawing.Point(8, 216)
        Me.Segment_40.Name = "Segment_40"
        Me.Segment_40.Size = New System.Drawing.Size(30, 30)
        Me.Segment_40.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_40.TabIndex = 81
        Me.Segment_40.TabStop = False
        '
        'Segment_39
        '
        Me.Segment_39.BackColor = System.Drawing.Color.Transparent
        Me.Segment_39.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_39.Image = CType(resources.GetObject("Segment_39.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_39, CType(39, Short))
        Me.Segment_39.Location = New System.Drawing.Point(32, 216)
        Me.Segment_39.Name = "Segment_39"
        Me.Segment_39.Size = New System.Drawing.Size(30, 30)
        Me.Segment_39.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_39.TabIndex = 82
        Me.Segment_39.TabStop = False
        '
        'Segment_38
        '
        Me.Segment_38.BackColor = System.Drawing.Color.Transparent
        Me.Segment_38.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_38.Image = CType(resources.GetObject("Segment_38.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_38, CType(38, Short))
        Me.Segment_38.Location = New System.Drawing.Point(8, 240)
        Me.Segment_38.Name = "Segment_38"
        Me.Segment_38.Size = New System.Drawing.Size(30, 30)
        Me.Segment_38.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_38.TabIndex = 83
        Me.Segment_38.TabStop = False
        '
        'Segment_37
        '
        Me.Segment_37.BackColor = System.Drawing.Color.Transparent
        Me.Segment_37.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_37.Image = CType(resources.GetObject("Segment_37.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_37, CType(37, Short))
        Me.Segment_37.Location = New System.Drawing.Point(32, 240)
        Me.Segment_37.Name = "Segment_37"
        Me.Segment_37.Size = New System.Drawing.Size(30, 30)
        Me.Segment_37.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_37.TabIndex = 84
        Me.Segment_37.TabStop = False
        '
        'Segment_36
        '
        Me.Segment_36.BackColor = System.Drawing.Color.Transparent
        Me.Segment_36.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_36.Image = CType(resources.GetObject("Segment_36.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_36, CType(36, Short))
        Me.Segment_36.Location = New System.Drawing.Point(8, 264)
        Me.Segment_36.Name = "Segment_36"
        Me.Segment_36.Size = New System.Drawing.Size(30, 30)
        Me.Segment_36.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_36.TabIndex = 85
        Me.Segment_36.TabStop = False
        '
        'Segment_35
        '
        Me.Segment_35.BackColor = System.Drawing.Color.Transparent
        Me.Segment_35.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_35.Image = CType(resources.GetObject("Segment_35.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_35, CType(35, Short))
        Me.Segment_35.Location = New System.Drawing.Point(32, 264)
        Me.Segment_35.Name = "Segment_35"
        Me.Segment_35.Size = New System.Drawing.Size(30, 30)
        Me.Segment_35.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_35.TabIndex = 86
        Me.Segment_35.TabStop = False
        '
        'Segment_34
        '
        Me.Segment_34.BackColor = System.Drawing.Color.Transparent
        Me.Segment_34.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_34.Image = CType(resources.GetObject("Segment_34.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_34, CType(34, Short))
        Me.Segment_34.Location = New System.Drawing.Point(64, 216)
        Me.Segment_34.Name = "Segment_34"
        Me.Segment_34.Size = New System.Drawing.Size(30, 30)
        Me.Segment_34.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_34.TabIndex = 87
        Me.Segment_34.TabStop = False
        '
        'Segment_33
        '
        Me.Segment_33.BackColor = System.Drawing.Color.Transparent
        Me.Segment_33.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_33.Image = CType(resources.GetObject("Segment_33.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_33, CType(33, Short))
        Me.Segment_33.Location = New System.Drawing.Point(88, 216)
        Me.Segment_33.Name = "Segment_33"
        Me.Segment_33.Size = New System.Drawing.Size(30, 30)
        Me.Segment_33.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_33.TabIndex = 88
        Me.Segment_33.TabStop = False
        '
        'Segment_32
        '
        Me.Segment_32.BackColor = System.Drawing.Color.Transparent
        Me.Segment_32.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_32.Image = CType(resources.GetObject("Segment_32.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_32, CType(32, Short))
        Me.Segment_32.Location = New System.Drawing.Point(64, 240)
        Me.Segment_32.Name = "Segment_32"
        Me.Segment_32.Size = New System.Drawing.Size(30, 30)
        Me.Segment_32.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_32.TabIndex = 89
        Me.Segment_32.TabStop = False
        '
        'Segment_31
        '
        Me.Segment_31.BackColor = System.Drawing.Color.Transparent
        Me.Segment_31.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_31.Image = CType(resources.GetObject("Segment_31.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_31, CType(31, Short))
        Me.Segment_31.Location = New System.Drawing.Point(88, 240)
        Me.Segment_31.Name = "Segment_31"
        Me.Segment_31.Size = New System.Drawing.Size(30, 30)
        Me.Segment_31.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_31.TabIndex = 90
        Me.Segment_31.TabStop = False
        '
        'Segment_30
        '
        Me.Segment_30.BackColor = System.Drawing.Color.Transparent
        Me.Segment_30.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_30.Image = CType(resources.GetObject("Segment_30.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_30, CType(30, Short))
        Me.Segment_30.Location = New System.Drawing.Point(64, 264)
        Me.Segment_30.Name = "Segment_30"
        Me.Segment_30.Size = New System.Drawing.Size(30, 30)
        Me.Segment_30.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_30.TabIndex = 91
        Me.Segment_30.TabStop = False
        '
        'Segment_29
        '
        Me.Segment_29.BackColor = System.Drawing.Color.Transparent
        Me.Segment_29.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_29.Image = CType(resources.GetObject("Segment_29.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_29, CType(29, Short))
        Me.Segment_29.Location = New System.Drawing.Point(88, 264)
        Me.Segment_29.Name = "Segment_29"
        Me.Segment_29.Size = New System.Drawing.Size(30, 30)
        Me.Segment_29.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_29.TabIndex = 92
        Me.Segment_29.TabStop = False
        '
        'Segment_28
        '
        Me.Segment_28.BackColor = System.Drawing.Color.Transparent
        Me.Segment_28.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_28.Image = CType(resources.GetObject("Segment_28.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_28, CType(28, Short))
        Me.Segment_28.Location = New System.Drawing.Point(176, 264)
        Me.Segment_28.Name = "Segment_28"
        Me.Segment_28.Size = New System.Drawing.Size(30, 30)
        Me.Segment_28.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_28.TabIndex = 93
        Me.Segment_28.TabStop = False
        '
        'Segment_27
        '
        Me.Segment_27.BackColor = System.Drawing.Color.Transparent
        Me.Segment_27.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_27.Image = CType(resources.GetObject("Segment_27.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_27, CType(27, Short))
        Me.Segment_27.Location = New System.Drawing.Point(144, 264)
        Me.Segment_27.Name = "Segment_27"
        Me.Segment_27.Size = New System.Drawing.Size(30, 30)
        Me.Segment_27.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_27.TabIndex = 94
        Me.Segment_27.TabStop = False
        '
        'Segment_26
        '
        Me.Segment_26.BackColor = System.Drawing.Color.Transparent
        Me.Segment_26.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_26.Image = CType(resources.GetObject("Segment_26.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_26, CType(26, Short))
        Me.Segment_26.Location = New System.Drawing.Point(120, 264)
        Me.Segment_26.Name = "Segment_26"
        Me.Segment_26.Size = New System.Drawing.Size(30, 30)
        Me.Segment_26.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_26.TabIndex = 95
        Me.Segment_26.TabStop = False
        '
        'Segment_25
        '
        Me.Segment_25.BackColor = System.Drawing.Color.Transparent
        Me.Segment_25.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_25.Image = CType(resources.GetObject("Segment_25.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_25, CType(25, Short))
        Me.Segment_25.Location = New System.Drawing.Point(200, 240)
        Me.Segment_25.Name = "Segment_25"
        Me.Segment_25.Size = New System.Drawing.Size(30, 30)
        Me.Segment_25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_25.TabIndex = 96
        Me.Segment_25.TabStop = False
        '
        'Segment_24
        '
        Me.Segment_24.BackColor = System.Drawing.Color.Transparent
        Me.Segment_24.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_24.Image = CType(resources.GetObject("Segment_24.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_24, CType(24, Short))
        Me.Segment_24.Location = New System.Drawing.Point(200, 216)
        Me.Segment_24.Name = "Segment_24"
        Me.Segment_24.Size = New System.Drawing.Size(30, 30)
        Me.Segment_24.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_24.TabIndex = 97
        Me.Segment_24.TabStop = False
        '
        'Segment_23
        '
        Me.Segment_23.BackColor = System.Drawing.Color.Transparent
        Me.Segment_23.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_23.Image = CType(resources.GetObject("Segment_23.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_23, CType(23, Short))
        Me.Segment_23.Location = New System.Drawing.Point(200, 264)
        Me.Segment_23.Name = "Segment_23"
        Me.Segment_23.Size = New System.Drawing.Size(30, 30)
        Me.Segment_23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_23.TabIndex = 98
        Me.Segment_23.TabStop = False
        '
        'Segment_22
        '
        Me.Segment_22.BackColor = System.Drawing.Color.Transparent
        Me.Segment_22.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_22.Image = CType(resources.GetObject("Segment_22.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_22, CType(22, Short))
        Me.Segment_22.Location = New System.Drawing.Point(176, 216)
        Me.Segment_22.Name = "Segment_22"
        Me.Segment_22.Size = New System.Drawing.Size(30, 30)
        Me.Segment_22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_22.TabIndex = 99
        Me.Segment_22.TabStop = False
        '
        'Segment_21
        '
        Me.Segment_21.BackColor = System.Drawing.Color.Transparent
        Me.Segment_21.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_21.Image = CType(resources.GetObject("Segment_21.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_21, CType(21, Short))
        Me.Segment_21.Location = New System.Drawing.Point(176, 240)
        Me.Segment_21.Name = "Segment_21"
        Me.Segment_21.Size = New System.Drawing.Size(30, 30)
        Me.Segment_21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_21.TabIndex = 100
        Me.Segment_21.TabStop = False
        '
        'Segment_20
        '
        Me.Segment_20.BackColor = System.Drawing.Color.Transparent
        Me.Segment_20.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_20.Image = CType(resources.GetObject("Segment_20.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_20, CType(20, Short))
        Me.Segment_20.Location = New System.Drawing.Point(120, 248)
        Me.Segment_20.Name = "Segment_20"
        Me.Segment_20.Size = New System.Drawing.Size(30, 30)
        Me.Segment_20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_20.TabIndex = 101
        Me.Segment_20.TabStop = False
        '
        'Segment_19
        '
        Me.Segment_19.BackColor = System.Drawing.Color.Transparent
        Me.Segment_19.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_19.Image = CType(resources.GetObject("Segment_19.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_19, CType(19, Short))
        Me.Segment_19.Location = New System.Drawing.Point(144, 248)
        Me.Segment_19.Name = "Segment_19"
        Me.Segment_19.Size = New System.Drawing.Size(30, 30)
        Me.Segment_19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_19.TabIndex = 102
        Me.Segment_19.TabStop = False
        '
        'Segment_18
        '
        Me.Segment_18.BackColor = System.Drawing.Color.Transparent
        Me.Segment_18.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_18.Image = CType(resources.GetObject("Segment_18.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_18, CType(18, Short))
        Me.Segment_18.Location = New System.Drawing.Point(120, 224)
        Me.Segment_18.Name = "Segment_18"
        Me.Segment_18.Size = New System.Drawing.Size(30, 30)
        Me.Segment_18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_18.TabIndex = 103
        Me.Segment_18.TabStop = False
        '
        'Segment_17
        '
        Me.Segment_17.BackColor = System.Drawing.Color.Transparent
        Me.Segment_17.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_17.Image = CType(resources.GetObject("Segment_17.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_17, CType(17, Short))
        Me.Segment_17.Location = New System.Drawing.Point(144, 224)
        Me.Segment_17.Name = "Segment_17"
        Me.Segment_17.Size = New System.Drawing.Size(30, 30)
        Me.Segment_17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_17.TabIndex = 104
        Me.Segment_17.TabStop = False
        '
        'Segment_16
        '
        Me.Segment_16.BackColor = System.Drawing.Color.Transparent
        Me.Segment_16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_16.Image = CType(resources.GetObject("Segment_16.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_16, CType(16, Short))
        Me.Segment_16.Location = New System.Drawing.Point(272, 0)
        Me.Segment_16.Name = "Segment_16"
        Me.Segment_16.Size = New System.Drawing.Size(30, 30)
        Me.Segment_16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_16.TabIndex = 105
        Me.Segment_16.TabStop = False
        '
        'Segment_15
        '
        Me.Segment_15.BackColor = System.Drawing.Color.Transparent
        Me.Segment_15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_15.Image = CType(resources.GetObject("Segment_15.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_15, CType(15, Short))
        Me.Segment_15.Location = New System.Drawing.Point(304, 0)
        Me.Segment_15.Name = "Segment_15"
        Me.Segment_15.Size = New System.Drawing.Size(30, 30)
        Me.Segment_15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_15.TabIndex = 106
        Me.Segment_15.TabStop = False
        '
        'Segment_14
        '
        Me.Segment_14.BackColor = System.Drawing.Color.Transparent
        Me.Segment_14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_14.Image = CType(resources.GetObject("Segment_14.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_14, CType(14, Short))
        Me.Segment_14.Location = New System.Drawing.Point(336, 0)
        Me.Segment_14.Name = "Segment_14"
        Me.Segment_14.Size = New System.Drawing.Size(30, 30)
        Me.Segment_14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_14.TabIndex = 107
        Me.Segment_14.TabStop = False
        '
        'Segment_13
        '
        Me.Segment_13.BackColor = System.Drawing.Color.Transparent
        Me.Segment_13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_13.Image = CType(resources.GetObject("Segment_13.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_13, CType(13, Short))
        Me.Segment_13.Location = New System.Drawing.Point(368, 0)
        Me.Segment_13.Name = "Segment_13"
        Me.Segment_13.Size = New System.Drawing.Size(30, 30)
        Me.Segment_13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_13.TabIndex = 108
        Me.Segment_13.TabStop = False
        '
        'Segment_12
        '
        Me.Segment_12.BackColor = System.Drawing.Color.Transparent
        Me.Segment_12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_12.Image = CType(resources.GetObject("Segment_12.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_12, CType(12, Short))
        Me.Segment_12.Location = New System.Drawing.Point(400, 0)
        Me.Segment_12.Name = "Segment_12"
        Me.Segment_12.Size = New System.Drawing.Size(30, 30)
        Me.Segment_12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_12.TabIndex = 109
        Me.Segment_12.TabStop = False
        '
        'Segment_11
        '
        Me.Segment_11.BackColor = System.Drawing.Color.Transparent
        Me.Segment_11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_11.Image = CType(resources.GetObject("Segment_11.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_11, CType(11, Short))
        Me.Segment_11.Location = New System.Drawing.Point(240, 32)
        Me.Segment_11.Name = "Segment_11"
        Me.Segment_11.Size = New System.Drawing.Size(30, 30)
        Me.Segment_11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_11.TabIndex = 110
        Me.Segment_11.TabStop = False
        '
        'Segment_10
        '
        Me.Segment_10.BackColor = System.Drawing.Color.Transparent
        Me.Segment_10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_10.Image = CType(resources.GetObject("Segment_10.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_10, CType(10, Short))
        Me.Segment_10.Location = New System.Drawing.Point(272, 32)
        Me.Segment_10.Name = "Segment_10"
        Me.Segment_10.Size = New System.Drawing.Size(30, 30)
        Me.Segment_10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_10.TabIndex = 111
        Me.Segment_10.TabStop = False
        '
        'Segment_9
        '
        Me.Segment_9.BackColor = System.Drawing.Color.Transparent
        Me.Segment_9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_9.Image = CType(resources.GetObject("Segment_9.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_9, CType(9, Short))
        Me.Segment_9.Location = New System.Drawing.Point(240, 0)
        Me.Segment_9.Name = "Segment_9"
        Me.Segment_9.Size = New System.Drawing.Size(30, 30)
        Me.Segment_9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_9.TabIndex = 112
        Me.Segment_9.TabStop = False
        '
        'Segment_8
        '
        Me.Segment_8.BackColor = System.Drawing.Color.Transparent
        Me.Segment_8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_8.Image = CType(resources.GetObject("Segment_8.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_8, CType(8, Short))
        Me.Segment_8.Location = New System.Drawing.Point(304, 32)
        Me.Segment_8.Name = "Segment_8"
        Me.Segment_8.Size = New System.Drawing.Size(30, 30)
        Me.Segment_8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_8.TabIndex = 113
        Me.Segment_8.TabStop = False
        '
        'Segment_7
        '
        Me.Segment_7.BackColor = System.Drawing.Color.Transparent
        Me.Segment_7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_7.Image = CType(resources.GetObject("Segment_7.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_7, CType(7, Short))
        Me.Segment_7.Location = New System.Drawing.Point(336, 32)
        Me.Segment_7.Name = "Segment_7"
        Me.Segment_7.Size = New System.Drawing.Size(30, 30)
        Me.Segment_7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_7.TabIndex = 114
        Me.Segment_7.TabStop = False
        '
        'Segment_6
        '
        Me.Segment_6.BackColor = System.Drawing.Color.Transparent
        Me.Segment_6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_6.Image = CType(resources.GetObject("Segment_6.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_6, CType(6, Short))
        Me.Segment_6.Location = New System.Drawing.Point(368, 32)
        Me.Segment_6.Name = "Segment_6"
        Me.Segment_6.Size = New System.Drawing.Size(30, 30)
        Me.Segment_6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_6.TabIndex = 115
        Me.Segment_6.TabStop = False
        '
        'Segment_5
        '
        Me.Segment_5.BackColor = System.Drawing.Color.Transparent
        Me.Segment_5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_5.Image = CType(resources.GetObject("Segment_5.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_5, CType(5, Short))
        Me.Segment_5.Location = New System.Drawing.Point(432, 0)
        Me.Segment_5.Name = "Segment_5"
        Me.Segment_5.Size = New System.Drawing.Size(30, 30)
        Me.Segment_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_5.TabIndex = 116
        Me.Segment_5.TabStop = False
        '
        'Segment_4
        '
        Me.Segment_4.BackColor = System.Drawing.Color.Transparent
        Me.Segment_4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_4.Image = CType(resources.GetObject("Segment_4.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_4, CType(4, Short))
        Me.Segment_4.Location = New System.Drawing.Point(464, 32)
        Me.Segment_4.Name = "Segment_4"
        Me.Segment_4.Size = New System.Drawing.Size(30, 30)
        Me.Segment_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_4.TabIndex = 117
        Me.Segment_4.TabStop = False
        '
        'Segment_3
        '
        Me.Segment_3.BackColor = System.Drawing.Color.Transparent
        Me.Segment_3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_3.Image = CType(resources.GetObject("Segment_3.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_3, CType(3, Short))
        Me.Segment_3.Location = New System.Drawing.Point(464, 0)
        Me.Segment_3.Name = "Segment_3"
        Me.Segment_3.Size = New System.Drawing.Size(30, 30)
        Me.Segment_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_3.TabIndex = 118
        Me.Segment_3.TabStop = False
        '
        'Segment_2
        '
        Me.Segment_2.BackColor = System.Drawing.Color.Transparent
        Me.Segment_2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_2.Image = CType(resources.GetObject("Segment_2.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_2, CType(2, Short))
        Me.Segment_2.Location = New System.Drawing.Point(400, 32)
        Me.Segment_2.Name = "Segment_2"
        Me.Segment_2.Size = New System.Drawing.Size(30, 30)
        Me.Segment_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_2.TabIndex = 119
        Me.Segment_2.TabStop = False
        '
        'Segment_1
        '
        Me.Segment_1.BackColor = System.Drawing.Color.Transparent
        Me.Segment_1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Segment_1.Image = CType(resources.GetObject("Segment_1.Image"), System.Drawing.Image)
        Me.Segment.SetIndex(Me.Segment_1, CType(1, Short))
        Me.Segment_1.Location = New System.Drawing.Point(432, 32)
        Me.Segment_1.Name = "Segment_1"
        Me.Segment_1.Size = New System.Drawing.Size(30, 30)
        Me.Segment_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Segment_1.TabIndex = 120
        Me.Segment_1.TabStop = False
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MnuFile, Me.MnuEdit, Me.MnuHelp})
        '
        'MnuFile
        '
        Me.MnuFile.Index = 0
        Me.MnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MnuFileNew, Me.MnuSave, Me.MnuLoad, Me.MnuFileExit})
        Me.MnuFile.Text = "&File"
        '
        'MnuFileNew
        '
        Me.MnuFileNew.Index = 0
        Me.MnuFileNew.Text = "&New"
        '
        'MnuSave
        '
        Me.MnuSave.Index = 1
        Me.MnuSave.Text = "&Save"
        '
        'MnuLoad
        '
        Me.MnuLoad.Index = 2
        Me.MnuLoad.Text = "&Load"
        '
        'MnuFileExit
        '
        Me.MnuFileExit.Index = 3
        Me.MnuFileExit.Text = "E&xit"
        '
        'MnuEdit
        '
        Me.MnuEdit.Index = 1
        Me.MnuEdit.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MnuEditUndo, Me.MnuEditOptions})
        Me.MnuEdit.Text = "&Edit"
        '
        'MnuEditUndo
        '
        Me.MnuEditUndo.Index = 0
        Me.MnuEditUndo.Shortcut = System.Windows.Forms.Shortcut.CtrlZ
        Me.MnuEditUndo.Text = "&Undo"
        '
        'MnuHelp
        '
        Me.MnuHelp.Index = 2
        Me.MnuHelp.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MnuHelpRules, Me.MnuHelpAbout})
        Me.MnuHelp.Text = "&Help"
        '
        'MnuHelpRules
        '
        Me.MnuHelpRules.Index = 0
        Me.MnuHelpRules.Text = "&Rules"
        '
        'MnuHelpAbout
        '
        Me.MnuHelpAbout.Index = 1
        Me.MnuHelpAbout.Text = "&About"
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
        'mnuEditOptions
        '
        Me.MnuEditOptions.Index = 1
        Me.MnuEditOptions.Text = "&Options"
        '
        'FrmDiscon
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(496, 417)
        Me.Controls.Add(Me.StatusBar1)
        Me.Controls.Add(Me.Dragger)
        Me.Controls.Add(Me.PPiece_24)
        Me.Controls.Add(Me.PPiece_23)
        Me.Controls.Add(Me.PPiece_22)
        Me.Controls.Add(Me.PPiece_21)
        Me.Controls.Add(Me.PPiece_20)
        Me.Controls.Add(Me.PPiece_19)
        Me.Controls.Add(Me.PPiece_18)
        Me.Controls.Add(Me.PPiece_17)
        Me.Controls.Add(Me.PPiece_16)
        Me.Controls.Add(Me.PPiece_15)
        Me.Controls.Add(Me.PPiece_14)
        Me.Controls.Add(Me.PPiece_13)
        Me.Controls.Add(Me.PPiece_12)
        Me.Controls.Add(Me.PPiece_11)
        Me.Controls.Add(Me.PPiece_10)
        Me.Controls.Add(Me.PPiece_9)
        Me.Controls.Add(Me.PPiece_8)
        Me.Controls.Add(Me.PPiece_7)
        Me.Controls.Add(Me.PPiece_6)
        Me.Controls.Add(Me.PPiece_5)
        Me.Controls.Add(Me.PPiece_4)
        Me.Controls.Add(Me.PPiece_3)
        Me.Controls.Add(Me.PPiece_2)
        Me.Controls.Add(Me.PPiece_1)
        Me.Controls.Add(Me.Segment_96)
        Me.Controls.Add(Me.Segment_95)
        Me.Controls.Add(Me.Segment_94)
        Me.Controls.Add(Me.Segment_93)
        Me.Controls.Add(Me.Segment_92)
        Me.Controls.Add(Me.Segment_91)
        Me.Controls.Add(Me.Segment_90)
        Me.Controls.Add(Me.Segment_89)
        Me.Controls.Add(Me.Segment_88)
        Me.Controls.Add(Me.Segment_87)
        Me.Controls.Add(Me.Segment_86)
        Me.Controls.Add(Me.Segment_85)
        Me.Controls.Add(Me.Segment_84)
        Me.Controls.Add(Me.Segment_83)
        Me.Controls.Add(Me.Segment_82)
        Me.Controls.Add(Me.Segment_81)
        Me.Controls.Add(Me.Segment_80)
        Me.Controls.Add(Me.Segment_79)
        Me.Controls.Add(Me.Segment_78)
        Me.Controls.Add(Me.Segment_77)
        Me.Controls.Add(Me.Segment_76)
        Me.Controls.Add(Me.Segment_75)
        Me.Controls.Add(Me.Segment_74)
        Me.Controls.Add(Me.Segment_73)
        Me.Controls.Add(Me.Segment_72)
        Me.Controls.Add(Me.Segment_71)
        Me.Controls.Add(Me.Segment_70)
        Me.Controls.Add(Me.Segment_69)
        Me.Controls.Add(Me.Segment_68)
        Me.Controls.Add(Me.Segment_67)
        Me.Controls.Add(Me.Segment_66)
        Me.Controls.Add(Me.Segment_65)
        Me.Controls.Add(Me.Segment_64)
        Me.Controls.Add(Me.Segment_63)
        Me.Controls.Add(Me.Segment_62)
        Me.Controls.Add(Me.Segment_61)
        Me.Controls.Add(Me.Segment_60)
        Me.Controls.Add(Me.Segment_59)
        Me.Controls.Add(Me.Segment_58)
        Me.Controls.Add(Me.Segment_57)
        Me.Controls.Add(Me.Segment_56)
        Me.Controls.Add(Me.Segment_55)
        Me.Controls.Add(Me.Segment_54)
        Me.Controls.Add(Me.Segment_53)
        Me.Controls.Add(Me.Segment_52)
        Me.Controls.Add(Me.Segment_51)
        Me.Controls.Add(Me.Segment_50)
        Me.Controls.Add(Me.Segment_49)
        Me.Controls.Add(Me.Segment_48)
        Me.Controls.Add(Me.Segment_47)
        Me.Controls.Add(Me.Segment_46)
        Me.Controls.Add(Me.Segment_45)
        Me.Controls.Add(Me.Segment_44)
        Me.Controls.Add(Me.Segment_43)
        Me.Controls.Add(Me.Segment_42)
        Me.Controls.Add(Me.Segment_41)
        Me.Controls.Add(Me.Segment_40)
        Me.Controls.Add(Me.Segment_39)
        Me.Controls.Add(Me.Segment_38)
        Me.Controls.Add(Me.Segment_37)
        Me.Controls.Add(Me.Segment_36)
        Me.Controls.Add(Me.Segment_35)
        Me.Controls.Add(Me.Segment_34)
        Me.Controls.Add(Me.Segment_33)
        Me.Controls.Add(Me.Segment_32)
        Me.Controls.Add(Me.Segment_31)
        Me.Controls.Add(Me.Segment_30)
        Me.Controls.Add(Me.Segment_29)
        Me.Controls.Add(Me.Segment_28)
        Me.Controls.Add(Me.Segment_27)
        Me.Controls.Add(Me.Segment_26)
        Me.Controls.Add(Me.Segment_25)
        Me.Controls.Add(Me.Segment_24)
        Me.Controls.Add(Me.Segment_23)
        Me.Controls.Add(Me.Segment_22)
        Me.Controls.Add(Me.Segment_21)
        Me.Controls.Add(Me.Segment_20)
        Me.Controls.Add(Me.Segment_19)
        Me.Controls.Add(Me.Segment_18)
        Me.Controls.Add(Me.Segment_17)
        Me.Controls.Add(Me.Segment_16)
        Me.Controls.Add(Me.Segment_15)
        Me.Controls.Add(Me.Segment_14)
        Me.Controls.Add(Me.Segment_13)
        Me.Controls.Add(Me.Segment_12)
        Me.Controls.Add(Me.Segment_11)
        Me.Controls.Add(Me.Segment_10)
        Me.Controls.Add(Me.Segment_9)
        Me.Controls.Add(Me.Segment_8)
        Me.Controls.Add(Me.Segment_7)
        Me.Controls.Add(Me.Segment_6)
        Me.Controls.Add(Me.Segment_5)
        Me.Controls.Add(Me.Segment_4)
        Me.Controls.Add(Me.Segment_3)
        Me.Controls.Add(Me.Segment_2)
        Me.Controls.Add(Me.Segment_1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(11, 30)
        Me.Menu = Me.MainMenu1
        Me.Name = "FrmDiscon"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Discon"
        CType(Me.PPiece_6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PPiece_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PPiece_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PPiece_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PPiece_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PPiece_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dragger, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PPiece_24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PPiece_23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PPiece_22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PPiece_21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PPiece_20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PPiece_19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PPiece_18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PPiece_17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PPiece_16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PPiece_15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PPiece_14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PPiece_13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PPiece_12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PPiece_11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PPiece_10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PPiece_9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PPiece_8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PPiece_7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_96, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_95, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_94, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_93, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_92, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_91, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_90, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_89, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_88, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_87, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_86, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_85, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_84, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_83, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_82, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_81, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_80, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_79, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_78, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_77, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_76, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_75, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_74, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_73, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_72, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_71, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_70, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_69, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_68, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_67, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_66, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_65, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_64, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_63, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_62, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_61, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_60, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_59, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_58, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_57, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_56, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_55, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_54, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_53, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_52, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_51, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_50, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_49, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_48, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_47, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_46, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_45, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_44, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_43, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_42, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_40, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_39, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_38, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_37, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_36, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_35, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PPiece, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segment, System.ComponentModel.ISupportInitialize).EndInit()
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

    Private aGame As New Game() 'Holds state of the game for Save / Load etc
    Private ReadOnly aSegments As New Segments() '
    Private ReadOnly aTurn As New Turn()
    Private ReadOnly aPPieces As New PPieces(12) 'Each piece has a tower (a collection of segments)
    Private aBoard As New Board()
    'These all relate to dragging and dropping pieces
    Private MouseButton As Short 'when the mouse button is clicked record which button is used.
    Private IsUDraggin As Boolean 'Drop and Drag support of PPieces
    Private IsUDisplayin As Boolean 'While displaying disable drag and drop
    Private OrigX As Long
    Private OrigY As Long
    Private ReadOnly aFileName As String = "SavedDisconGame.bin"

    Private Sub FrmDiscon_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Closed
        End
    End Sub

    Private Sub FrmDiscon_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        'Set up the game -- All New objects should be created here.... (i.e. have other Init routines for File New Game that don't create new objects. Reuse objects
        MouseButton = VB6.MouseButtonConstants.LeftButton 'default button is left

        'frmPreferences.ShowDialog() 'Find out who's playing

        frmHistory.Show()

        'Me.Invalidate()

        'aTurn = New Turn 'Create objects for game: Turn class keeps track of who's turn it is / incl. basic game/rule info like MaxHeight
        'aBoard = New Board 'Board class keeps track of where pieces are and relates closely to frmDiscon
        'aSegments = New Segments 'A collection of coloured discs
        'aPPieces = New PPieces(aTurn.MaxHeight) 'The players each have six red playing pieces This is a collection of them -- (Max Height is stored here based on number of players see instructiosn)

        aSegments.Setup(aBoard) 'layout the coloured discs on the board and then randomize them

        'aPPieces.Setup(aBoard) 'They are positioned in each of the four corners
        aPPieces.SetBoardRef(aBoard)
        aTurn.Init() 'works our active players and maxheight and who'll go first
        aGame.GameOver = False

        aSegments.Resize()
        aPPieces.ReSize()
        aSegments.UpdateControlPositions()
        aPPieces.UpdateControlPositions()
        ShowStatus() 'Let people know whose turn it is

        ' Have any computer turns
        Do While aTurn.GetPlayer.Status = 2 And Not aGame.GameOver 'Computer
            aTurn.GetPlayer.CompMove(aPPieces, aSegments, aTurn)
            frmHistory.Cout(aTurn.Message & vbNewLine)
            If CountOwned() = aSegments.MaxSegments() Then
                aGame.GameOver = True
                MsgBox(aTurn.LeadingPlayer() & " won.")
            End If

            aSegments.UpdateControlPositions()
            aPPieces.UpdateControlPositions()
            ShowStatus() 'Let people know whose turn it is
        Loop

    End Sub

    Private Sub FrmDiscon_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        aBoard.Draw(e.Graphics)
    End Sub

    Private Sub FrmDiscon_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
        Dim minDim As Short

        If VB6.PixelsToTwipsY(Me.ClientRectangle.Height) > VB6.PixelsToTwipsX(Me.ClientRectangle.Width) Then
            minDim = VB6.PixelsToTwipsX(Me.ClientRectangle.Width)
        Else
            minDim = VB6.PixelsToTwipsY(Me.ClientRectangle.Height)
        End If
        aBoard.PositionHeight = minDim / (aBoard.MaxY + 2)
        aBoard.PositionWidth = aBoard.PositionHeight
        Me.Invalidate()
        If Not aPPieces.GetBoardRef() Is Nothing Then 'on initialization this runs but we want to wait do it in the form onload procedure anyway...
            aSegments.UpdateControlPositions()
            aSegments.Resize()
            'aPPieces.SetBoardRef(aBoard)
            aPPieces.UpdateControlPositions()
            aPPieces.ReSize()
        End If
    End Sub

    Private Sub Ppiece_1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PPiece_1.MouseUp, PPiece_2.MouseUp, PPiece_3.MouseUp, PPiece_4.MouseUp, PPiece_5.MouseUp, PPiece_6.MouseUp, PPiece_7.MouseUp, PPiece_8.MouseUp, PPiece_9.MouseUp, PPiece_10.MouseUp, PPiece_11.MouseUp, PPiece_12.MouseUp, PPiece_13.MouseUp, PPiece_14.MouseUp, PPiece_15.MouseUp, PPiece_16.MouseUp, PPiece_17.MouseUp, PPiece_18.MouseUp, PPiece_19.MouseUp, PPiece_20.MouseUp, PPiece_21.MouseUp, PPiece_22.MouseUp, PPiece_23.MouseUp, PPiece_24.MouseUp
        'release the playing piece. 'e.x and e.y are pixel position within the piece
        Dim aPiece As PPiece 'Player piece
        Dim aXFinish As Short
        Dim aYFinish As Short

        If IsUDraggin Then
            IsUDraggin = False
            aPiece = aPPieces.GetPieceRef(sender.Tag) 'This is who (which player piece to be precise) moved
            aXFinish = aBoard.GetXPosFromMouse(sender.left)
            aYFinish = aBoard.GetYPosFromMouse(sender.top)
            If aXFinish = aPiece.XPos And aYFinish = aPiece.YPos Then '(We just clicked on the thing
                DisplayTower(sender)
            Else 'we tried to move somewhere
                Segment_DragDrop(sender, aXFinish, aYFinish)
            End If

        End If
    End Sub

    Private Sub PPieceMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PPiece_1.MouseDown, PPiece_2.MouseDown, PPiece_3.MouseDown, PPiece_4.MouseDown, PPiece_5.MouseDown, PPiece_6.MouseDown, PPiece_7.MouseDown, PPiece_8.MouseDown, PPiece_9.MouseDown, PPiece_10.MouseDown, PPiece_11.MouseDown, PPiece_12.MouseDown, PPiece_13.MouseDown, PPiece_14.MouseDown, PPiece_15.MouseDown, PPiece_16.MouseDown, PPiece_17.MouseDown, PPiece_18.MouseDown, PPiece_19.MouseDown, PPiece_20.MouseDown, PPiece_21.MouseDown, PPiece_22.MouseDown, PPiece_23.MouseDown, PPiece_24.MouseDown
        'This code is designed for picking up a player piece with the mouse
        'e contains the mouse position
        'the sender is the object that detected the mousedown event... should be the player piece
        'e.x and e.y are pixel position within the piece
        'add them to the sender.left and sender.top to derive the mouse position on the form
        If Not aGame.GameOver And Not IsUDraggin And Not IsUDisplayin Then 'Not dragging and not displaying
            IsUDraggin = True
            OrigX = e.X 'remember where we started from (clicked)
            OrigY = e.Y
            If e.Button = MouseButtons.Right Then
                MouseButton = VB6.MouseButtonConstants.RightButton
            Else
                MouseButton = VB6.MouseButtonConstants.LeftButton
            End If
        End If
    End Sub

    Private Sub PPieceMouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PPiece_1.MouseMove, PPiece_2.MouseMove, PPiece_3.MouseMove, PPiece_4.MouseMove, PPiece_5.MouseMove, PPiece_6.MouseMove, PPiece_7.MouseMove, PPiece_8.MouseMove, PPiece_9.MouseMove, PPiece_10.MouseMove, PPiece_11.MouseMove, PPiece_12.MouseMove, PPiece_13.MouseMove, PPiece_14.MouseMove, PPiece_15.MouseMove, PPiece_16.MouseMove, PPiece_17.MouseMove, PPiece_18.MouseMove, PPiece_19.MouseMove, PPiece_20.MouseMove, PPiece_21.MouseMove, PPiece_22.MouseMove, PPiece_23.MouseMove, PPiece_24.MouseMove
        'Reposition the player piece
        'e.x and e.y are relative pixel position within the piece
        'add them to the sender.left and sender.top to derive the mouse position on the form
        If IsUDraggin Then
            'sender is Player piece control (picturebox)
            sender.Left = sender.left + e.X - OrigX
            sender.Top = sender.top + e.Y - OrigY
        End If
    End Sub

    'Menu
    Public Sub MnuFileNew_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MnuFileNew.Click

        aTurn.Init() 'Turn object works out active players, maximum tower height and who'll go first
        aSegments.Setup(aBoard) 'segments are drawn and randomized
        aPPieces.Setup(aTurn.MaxHeight)
        aPPieces.SetBoardRef(aBoard) 'The pieces, have towers and, when adding, they need to know about height restrictions.
        aGame.GameOver = False

        'if computer has first move initiate that
        Do While aTurn.GetPlayer.Status = 2 And Not aGame.GameOver 'Computer
            aTurn.GetPlayer.CompMove(aPPieces, aSegments, aTurn)
            frmHistory.Cout(aTurn.Message & vbNewLine)
            If CountOwned() = aSegments.MaxSegments() Then
                aGame.GameOver = True
                MsgBox(aTurn.LeadingPlayer() & " won.")
            End If
            aSegments.UpdateControlPositions()
            aPPieces.UpdateControlPositions()
            ShowStatus()
        Loop

    End Sub

    Private Sub MnuFileLoad(sender As Object, e As EventArgs) Handles MnuLoad.Click
        Try
            If (File.Exists(aFileName)) Then

                Dim aStream As Stream = File.OpenRead(aFileName)
                Dim deserializer As BinaryFormatter = New BinaryFormatter()
                aGame = DirectCast(deserializer.Deserialize(aStream), Game)
                aStream.Close()
                'End
            Else

                Throw New System.Exception(aFileName + " wasn't found.")
            End If
            frmHistory.txtHistory.Text = aGame.History
            aGame.GetTurn(aTurn) 'Copies current player and player info
            aGame.GetPPieces(aPPieces) 'Copies player piece info
            aGame.GetSegments(aSegments) 'Copies segment info
            aGame.GetBoard(aBoard) 'Copies board info
            frmHistory.Show()
            'aBoard.Draw() 'This would be possible if Segments and Pieces lived in aBoard
            aSegments.Resize()
            aSegments.UpdateControlPositions()
            aPPieces.ReSize()
            aPPieces.UpdateControlPositions()

            'if computer has first move initiate that
            Do While aTurn.GetPlayer.Status = 2 And Not aGame.GameOver 'Computer
                aTurn.GetPlayer.CompMove(aPPieces, aSegments, aTurn)
                frmHistory.Cout(aTurn.Message & vbNewLine)
                If CountOwned() = aSegments.MaxSegments() Then
                    aGame.GameOver = True
                    MsgBox(aTurn.LeadingPlayer() & " won.")
                End If
            Loop
            ShowStatus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub MnuFileSave_Click(sender As Object, e As EventArgs) Handles MnuSave.Click
        Try
            'These things should just live in aGame all the time rather than here in the form...
            aGame.History = frmHistory.txtHistory.Text
            aGame.SetTurn(aTurn) 'Copies current player and player info
            aGame.SetPPieces(aPPieces) 'Copies player piece info
            aGame.SetSegments(aSegments) 'Copies segment info
            aGame.SetBoard(aBoard) 'Copies board info

            Dim aStream As Stream = File.Create(aFileName)
            Dim serializer As BinaryFormatter = New BinaryFormatter()
            serializer.Serialize(aStream, aGame)
            aStream.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub MnuFileExit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MnuFileExit.Click
        End
    End Sub

    Public Sub MnuEditUndo_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MnuEditUndo.Click
        aTurn.Undo(1)
        ShowStatus() 'Because move is possible wrong
    End Sub

    Private Sub MnuEditOptions_Click(sender As Object, e As EventArgs) Handles MnuEditOptions.Click
        frmPreferences.ShowDialog() 'Modal
        aTurn.SetStatus() 'update players
        ShowStatus()
        Do While aTurn.GetPlayer.Status = 2 And Not aGame.GameOver 'Computer
            Application.DoEvents()
            aTurn.GetPlayer.CompMove(aPPieces, aSegments, aTurn)
            frmHistory.Cout(aTurn.Message & vbNewLine)
            If CountOwned() = aSegments.MaxSegments() Then
                aGame.GameOver = True
                MsgBox(aTurn.LeadingPlayer() & " won.")
            End If

            aSegments.UpdateControlPositions()
            aPPieces.UpdateControlPositions()
            ShowStatus()
        Loop

    End Sub

    Private Sub MnuHelpRules_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuHelpRules.Click
        Try
            Dim AppPath As String = System.AppDomain.CurrentDomain.BaseDirectory
            System.Diagnostics.Process.Start(AppPath + "DisconHelp.html")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MnuHelpAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuHelpAbout.Click
        frmAbout.Show()
    End Sub

    'Helper routines
    Private Function CountOwned() As Object
        'Check progress in game by counting 'captured' segments. 96 =aGame.GameOver
        Dim i As Short

        CountOwned = 0
        For i = 1 To aTurn.MaxPlayer * aTurn.MaxPPiece 'MaxPlayer 24 '4 players * 6 player pieces
            CountOwned += aPPieces.GetPieceRef(i).GetTowerRef.Height
        Next
    End Function

    Private Sub DisplayTower(ByRef Source As System.Windows.Forms.Control)
        'Click and release on a player piece displays tower
        'Called (see below) from mouseup after determining no actual move has occured (click on self)
        Dim aPiece As PPiece
        Dim i As Integer

        If Not IsUDisplayin Then
            IsUDisplayin = True 'prevent drag and drop
            aPiece = aPPieces.GetPieceRef(Source.Tag)
            aPiece.DisplayTower()
            For i = 1 To 10
                Application.DoEvents()
                System.Threading.Thread.Sleep(100)
            Next
            aPiece.UpdateControlPosition() 'redraws in the normal position
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

        aPiece = aPPieces.GetPieceRef(Source.Tag) 'This is who (which piece to be precise) moved
        'we could pass apiece from the mouseup routine as we've worked it out there already
        aPlayer = aTurn.GetPlayer 'This is who's turn it is
        If aPlayer.PID <> aPiece.Owner Then
            MsgBox("It's player number " & aPlayer.PID & "'s turn.")
            'aPiece.Draw() 'aPPieces.draw()
        Else 'the right person has had a turn
            oldValue = aPiece.Score 'remember the current score
            aTurn.SaveSource(aPiece) 'Before move, remember for undo
            If MouseButton = VB6.MouseButtonConstants.LeftButton Then 'clicking on a new segment to capture it
                If aPiece.Move(x, y) Then 'move player piece (image and object including existing tower) if destination is legal
                    aSegment = aSegments.GetSegmentXY(x, y) 'Note: there maybe more than one this is basically a test that it's not empty...
                    If aSegment IsNot Nothing Then 'There are one or more segments to add
                        If aSegments.AddAny(aPiece) Then 'Add any segments found that are not already in the tower if not > Tower MaxHeight
                            If Not aTurn.IncMove() Then 'count move. If second, check you're not in foreign territory
                                aTurn.Undo(2)
                                aTurn.Message = "Undoing: " & aTurn.Message
                            End If
                        Else
                            MsgBox(aSegments.Message) 'Problem adding: display reason
                            aTurn.Undo(2) 'The piece and it's tower segments should all return to the position before move 1 of this player's turn
                            aTurn.Message = "Undoing: " & aTurn.Message
                        End If
                    Else
                        If Not aTurn.IncMove() Then 'count move. If second, check you're not in foreign territory
                            aTurn.Undo(2)
                            aTurn.Message = "Undoing: " & aTurn.Message
                        End If
                    End If
                Else 'illegal move
                    MsgBox("Illegal move from " & aPiece.XPos & ", " & aPiece.YPos & " to " & x & ", " & y) 'no need to undo
                End If
            Else 'right click is for abandoning a pile of segments
                If aPiece.Abandon(x, y) Then 'move player piece (image and object removes tower and updates) (but not tower yet) if destination is legal
                    If aSegments.AddAny(aPiece) Then
                        If Not aTurn.IncMove() Then 'count move. If second, check you're not in foreign territory
                            aTurn.Undo(2)
                            aTurn.Message = "Undoing: " & aTurn.Message
                        End If
                    Else
                        aTurn.Undo(2)
                        aTurn.Message = "Undoing: " & aTurn.Message
                    End If
                Else
                    MsgBox("Illegal abandon from " & aPiece.XPos & ", " & aPiece.YPos & " to " & x & ", " & y)
                End If
            End If
            newValue = aPiece.Score
            aPlayer.Score = aPlayer.Score - oldValue + newValue 'aPlayer.GetScore could just sum all piece scores
            If aTurn.Move = 2 Then 'incMove generally happens before this so this means we've just finished move 1
                aTurn.Message = aPiece.Owner & ":" & aPiece.PPID & " to " & aPiece.XPos & ", " & aPiece.YPos
                frmHistory.Cout(aTurn.Message)
            Else
                If aTurn.Message.Substring(0, 4) <> "Undo" Then
                    aTurn.Message = " and " & aPiece.PPID & " to " & aPiece.XPos & ", " & aPiece.YPos
                End If
                frmHistory.Cout(aTurn.Message & vbNewLine)
            End If
            If CountOwned() = aSegments.MaxSegments() Then
                aGame.GameOver = True
                MsgBox(aTurn.LeadingPlayer() & " won.")
            End If
        End If
        aPiece.UpdateTooltip() 'to display colour and height
        aPiece.UpdateControlPosition() ''including tower (segments)
        ShowStatus()

        Do While aTurn.GetPlayer.Status = 2 And Not aGame.GameOver 'Computer
            Application.DoEvents()
            aTurn.GetPlayer.CompMove(aPPieces, aSegments, aTurn)
            frmHistory.Cout(aTurn.Message & vbNewLine)
            If CountOwned() = aSegments.MaxSegments() Then
                aGame.GameOver = True
                MsgBox(aTurn.LeadingPlayer() & " won.")
            End If
            'Updating control positions happens in compmove
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
