   M S B A M L   `   `   `  ����>  :FEI, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:FEI.pages	FEI.pages  5      %    FEI.pages.Configuracion_bdlocal   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:FEI.pages     5      -   5          N� Title$'  !Configuracion Base de Datos Local��5       � 	Resources 5	         BaseButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType ��Name J� SnapsToDevicePixels ��Name	 �� Triggers
 P� Property P� Value �� 
TargetName��%�  &	        �� 5
   
   " ��6(   .�5      ��  �@�FocusVisualStyle 61   Z� �� 5       � �� �#1ba1e26+   �� 5       � �� �#1684ba6,   �� 5       � ��$ 1q�60   �� 5       � �� �#0000006+   �� 5       � ��$ Center=�6;   �� 5       � ��$ Center=�69   �� 5       � ��$ 	16,3,16,3q�6(   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $ Chrome��6!   #��z��5   !   #��z��5   !   #��z��5   !    . ._�5      �� $ 	Presenter��6/   #��z��6B   #��z��5   %   #��z��5   %   ��. # z 5   %   5       	 5!      P� 5"      
 � {� .  . �5#   "   ��  � �� �#3333336?   5$      P� 5%      
 �@J�IsMouseOver . . �5&   "   ��  � �� �#dddddd6?   �� 5'   "    � �� �#cccccc6@   �� 5(   "    � �� �#3333336?   5)      P� 5*      
 � �� . . �5+   "   ��  � �� �#1ba1e26?   �� 5,   "    � �� �#1ba1e26@   �� 5-   "    � �� �#ffffff6?   5.      P� 5/      
 �@J�	IsFocused . . �50   "   �� $ Chrome��6)    � �� �#1ba1e26T   51      53      55      56      57      .��58      � 
������� � RowDefinitions 59   
   �� 5:      $
��Auto �6   �� 5;      $��* �6    � ColumnDefinitions 5=   
   �� 5>      $��* �6   .+�5@   
   �� $��0��6   $��0��6    $��4��6-   $��BASE DE DATOS LOCAL��6A   $��Center=�6_   $��14(�6�   $
��Bold"�6�   $��Calibri)�6�   ���#dbeaf96�   � 5A   
   $��0��6   $��1��6    5B      �� 5C      $��* �6     5E      �� 5F      $��* �6#   �� 5G      $��3* �6#   �� 5H      $��3* �6#   �� 5I      $��* �6#   .+�5K      �� $��1��6   $��0��6%   $��2��62   $��	0,20,0,20q�6F   ���#DBDBDB �� CornerRadius$ 0��6o   $��1,1,1,1q�6�   ._�5L      � $��10,20,10,20q�6   $	��450��6-    5M      �� 5N      $
��Auto �6$   �� 5O      $
��Auto �6$   �� 5P      $
��Auto �6$   �� 5Q      $
��Auto �6$   �� 5R      $
��Auto �6$   �� 5S      $
��Auto �6$   �� 5T      $
��Auto �6$   �� 5U      $��* �6$    5W      �� 5X      $��2* �6'   �� 5Y      $��2* �6'   .+�5[      �� $��0��6   $��0��6(   $��	Gestor BD��65   $
��Left=�6I   $��	0,10,0,10q�6k   $
��Bold"�6~   �� 5\      -   5         ��Name$ cboGestorBD��5\      $��1��61   $��0��6B   $	��180��6O   $��	0,10,0,10q�6[   $��Right=�6n     ComboBoxFlatStyle#��[ 6�   �� 5]      $��0��6   $��1��6(   $ ��Driver de Gestor BD (ODBC)��65   $��	0,10,0,10q�6[   $
��Left=�6n   $
��Bold"�6�   �� 5^      -   5         ��Name$ 	txtDriver��5^      $��1��6/   $��1��6?   $��	0,10,0,10q�6L   $	��180��6a   $��Right=�6m   �� 5_      $��0��6   $��2��6(   $��Servidor BD��65   $��	0,10,0,10q�6L   $
��Left=�6_   $
��Bold"�6�   �� 5`      -   5        $ txtServidor��5`      $��1��61   $��2��6A   $��	0,10,0,10q�6N   $	��180��6b   $��Right=�6n   �� 5a      $��0��6   $��3��6(   $��Puerto del servidor BD��65   $��	0,10,0,10q�6W   $
��Left=�6j   $
��Bold"�6�   �� 5b      -   5        $ 	txtPuerto��5b      $��1��6/   $��3��6?   $��	0,10,0,10q�6L   $	��180��6`   $��Right=�6l   �� 5c      $��0��6   $��4��6(   $��Nombre de Base Datos��65   $��	0,10,0,10q�6W   $
��Left=�6j   $
��Bold"�6�   �� 5d      -   5        $ txtNombreBD��5d      $��1��61   $��4��6A   $��	0,10,0,10q�6N   $	��180��6b   $��Right=�6n   �� 5e      $��0��6   $��5��6(   $��Usuario��65   $��	0,10,0,10q�6H   $
��Left=�6[   $
��Bold"�6}   �� 5f      -   5        $ 
txtUsuario��5f      $��1��60   $��5��6@   $��	0,10,0,10q�6M   $	��180��6a   $��Right=�6m   �� 5g      $��0��6   $��6��6(   $��Contraseña��65   $��	0,10,0,10q�6K   $
��Left=�6^   $
��Bold"�6�   G� 5h      -   5         G�Name$ txtContrasenia��5h       $��1��68   $��6��6H   $��	0,10,0,10q�6U   $	��180��6i   $��Right=�6u   ]� 5i      $��0,20,0,0q�6    $��0��62   $��7��6B   $��2��6O   $��Stretch=�6c   $	��Top=�6�   .+�5p      �� -	   5         ��Name$ btnCrear��5p   >   $��0,0,5,0q�6!   $	��145��62   $��Right=�6P   $��Bottom=�6�   .��5q      ��  �� Orientation$ 
Horizontal=�6)   .+�5r   "   �� -
   5         ��Name$ image��5r   (   $,��&/FEI;component/images/add-database.png��67   $��18��6g   $��26��6s   �� 5s   "   -   5         ��Name$ 	TextBoton��5s   (   $��Crear Base de Datos��6;   5t      5u      �� 5v      -   5        $ 
btnGuardar��5v   >   $��0,0,0,0q�6!   $	��100��62   $��Right=�6R   $��Bottom=�6�   .��5w      �� $ 
Horizontal=�6)   .+�5x   "   �� -   5        $ imageGuardar��5x   (   $)��#/FEI;component/images/save-icon.png��6>   $��18��6k   $��26��6w   �� 5y   "   -   5        $ TextBotonGuardar��5y   (   $��Guardar��6B   5z      5{      5|      5}      5~      5�      5�      5�      