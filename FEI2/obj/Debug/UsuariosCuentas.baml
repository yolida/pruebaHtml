   M S B A M L   `   `   `  ����>  :FEI, Version=4.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:FEIFEI  5   	       FEI.UsuariosCuentas   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:FEI     5   	   -   5          � Title$  Usuarios Cuentas��5   	   $	��350��6"   $	��400��6/    � 
ResizeMode$ NoResize=�6;    � WindowStartupLocation$ CenterScreen=�6R    � Icon$ images/fei_cuadro.ico��6w    � 	Resources 5	         BaseButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType	 J� SnapsToDevicePixels
 �� Triggers P� Property P� Value �� 
TargetName��%�  &	        �� 5
   
   " ��6(   .�5      ��  �@�FocusVisualStyle 61   Z� �� 5       � �� �#1ba1e26+   �� 5       � �� �#1684ba6,   �� 5       � ��$ 1q�60   �� 5       � �� �#0000006+   �� 5       � ��$ Center=�6;   �� 5       � ��$ Center=�69   �� 5       � ��$ 	16,3,16,3q�6(   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $��Chrome��6!   #��z��5   !   #��z��5   !   #��z��5   !   	 . ._�5      �� $��	Presenter��6/   #��z��6@   #��z��5   %   #��z��5   %   ��. #	 z	 5   %   5       
 5!      P� 5"       � {� .  . �5#   "   ��  � �� �#3333336?   5$      P� 5%       �@J�IsMouseOver . . �5&   "   ��  � �� �#dddddd6?   �� 5'   "    � �� �#cccccc6@   �� 5(   "    � �� �#3333336?   5)      P� 5*       � �� . . �5+   "   ��  � �� �#1ba1e26?   �� 5,   "    � �� �#1ba1e26@   �� 5-   "    � �� �#ffffff6?   5.      P� 5/       �@J�	IsFocused . . �50   "   �� $ Chrome��6)    � �� �#1ba1e26T   51      53      55      56      57      .��58      � $��20,20,20,20q�6    � RowDefinitions 59   
   �� 5:      $
��Auto �6   �� 5;      $
��Auto �6   �� 5<      $
��Auto �6   �� 5=      $
��Auto �6    � ColumnDefinitions 5?   
   �� 5@      $��2* �6   �� 5A      $��2* �6   �� 5B      $��2* �6   .+�5D   
   �� -   5         ��Name$ cboEmpresas��5D      $��0��6(   $��0��68   $��2��6E   $��
0,20,20,10q�6Y   $��Center=�6m   $
��Left=�6�     ComboBoxFlatStyle#��[ 6�   �� 5E   
   -   5         ��Name$ 
btnGuardar��5E   C   $��2��6   $��0��6"   $��	0,20,0,10q�60   $��Right=�6W   $��Bottom=�6�   .��5F      ��  �� Orientation$ 
Horizontal=�6   .+�5G      �� -   5         ��Name$ 
imageBoton��5G      $��images/add-list.png��6,   $��18��6I   $��26��6U   �� 5H      -   5         ��Name$ 	TextBoton��5H      $��Agregar��6+   5I      5J      &   System.Windows.Controls.DataGrid  5K   
   -   5          Name$ 
dgEmpresas��5K   p   $��0��6   $��1��6#   $��3��61   $��	0,20,0,20q�6E      FrozenColumnCount$ 0��6Y      AutoGenerateColumns .     CanUserAddRows .     SelectionMode$ Single=�5N         CanUserDeleteRows .     CanUserResizeRows .  
�������   HeadersVisibility$ Column=�5R         VerticalGridLinesBrush �#000000   GridLinesVisibility$
 None=�5T         SelectionUnit$ FullRow=�6.   $	��650��6G   $	��100��6W       Columns  5U      0  *System.Windows.Controls.DataGridTextColumn  5V      ,  &System.Windows.Controls.DataGridColumn!   
IsReadOnly! . "   MinWidth$" 90Q�6W   #   CanUserReorder# .  $   Width5  /System.Windows.Controls.DataGridLengthConverter$$ 3* 6|   1  +System.Windows.Controls.DataGridBoundColumn%   Binding% 6%   �� *RazonSocial+&   Header& 5W      �� 5X      $��Razón Social��6%   $��Center=�69   $��Center=�6T   '   ElementStyle' 5Z      �� 5[      .�5\      ��  �@��TextAlignment$
 Left=�6H   5]      5_      5b      �� 5c   
   -   5        $ 
btnRemover��5c   C   $��0��6   $��2��6"   $��	0,20,0,10q�60   $
��Left=�6W   $��Bottom=�6�   .��5d      �� $ 
Horizontal=�6   .+�5e      �� -   5        $ imageRemover��5e      $��images/remove-icon.png��6.   $��18��6N   $��26��6Z   �� 5f      -	   5        $ TextRemover��5f      $��Remover��6-   5g      5h      �� 5i   
   -
   5        $ btnSalir��5i   C   $��2��6   $��2��6"   $��	0,20,0,10q�60   $��Right=�6U   $��Bottom=�6�   .��5j      �� $ 
Horizontal=�6   .+�5k      �� -   5        $ 
imageSalir��5k      $��images/close.png��6,   $��18��6F   $��26��6R   �� 5l      -   5        $ 	TextSalir��5l      $��Cerrar��6+   5m      5n      5o      5p      