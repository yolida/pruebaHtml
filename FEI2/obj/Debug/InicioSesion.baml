   M S B A M L   `   `   `  ����>  :FEI, Version=4.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:FEIFEI  5   	       FEI.InicioSesion   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:FEI     5   	   -   5          � Title$  Inicio de Sesion��5   	   $	��350��6"   $	��320��6/   $	��350��6;   $	��320��6K   $	��400��6Z    � WindowStyle$
 None=�6�    � AllowsTransparency .  � 
ResizeMode$ NoResize=�6�    � WindowStartupLocation$ CenterScreen=�6�    � Icon$ images/fei_cuadro.ico��6�   $y�Visible=�6R  ��6k   Z� .��5	      ��  �� CornerRadius$ 5,5,5,5��6   ���	#FF000000$��0,0,0,0q�6=   ��5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      � 	 � Color$	 #d3dbdd��6   
 � Offset$
 0Q�6/   � 5      $	 #d3dbdd��6   $
 1Q�6/   5      ._�5   
   � $	��350��6   $	��Top=�6    � RowDefinitions 5      �� 5      $	��130 �6    �� 5      $��40 �6    �� 5      $��40 �6    �� 5      $��40 �6    �� 5      $��50 �6     � ColumnDefinitions 5      �� 5      $��2* �6#   �� 5      $��4* �6#   .+�5      �� -   5         ��Name$ imageIngresar��5      $��10,20,10,20q�6-   $��0��6B   $��2��6R   $��0��6f   $ ��images/fei_cuadro_logo.png��6s   $
��Fill=�6�   �� 5      $��4,0,0,0q�6   $
��Bold"�6&   $��16,0,0,0q�69   $��0��6K   $��1��6[   $��EMPRESA:��6h   $
��Left=�6{   $��Center=�6�   �� 5       -   5         ��Name$ 
cboEmpresa��5       $��1��6+   $��1��6;   $��	10,7,20,0q�6H    �� TextAlignment$ Center=�6[   $��Center=�6|   $��Center=�6�   $��27��6�   $	��Top=�6�   �� 5!      $��4,0,0,0q�6   $
��Bold"�6&   $��16,0,0,0q�69   $��0��6K   $��2��6[   $��USUARIO:��6h   $
��Left=�6{   $��Center=�6�   �� 5"      -   5         ��Name$ 
txtUsuario��5"      $��1��6+   $��2��6;   $��	10,7,20,7q�6H    �� TextAlignment$ Center=�6\   $��Center=�6t   $
��Bold"�6�   �� 5#      $��4,0,0,0q�6   $
��Bold"�6&   $��16,0,0,0q�69   $��0��6K   $��3��6[   $��CONTRASEÑA:��6h   $
��Left=�6   $��Center=�6�   G� 5$      -   5         G�Name$ txtPassword��5$   9   $��1��6   $��3��6,   
�������$��	10,7,20,7q�6f   $ Center=�6{   $��Center=�6�   $
��Bold"�6�   6�   ]� 5%      $��0��6   $��4��6(   $��2��65   $��Bottom=�6I   .+�5&      �� -   5         ��Name$ btnIngresar��5&   8   $��	20,10,0,0q�6   $	��120��6,   $
��Left=�6M   $	��Top=�6j   .��5'      ��  �� Orientation$ 
Horizontal=�6!   .+�5(      �� -   5        $ imageButton��5(       $��images/login-incio.png��65   $
��Fill=�6U   $��15��6d   $��20��6p   �� 5)      -   5         ��Name$ 	TextBoton��5)       $��INGRESAR��63   5*      5+      �� 5,      -	   5        $ 	btnCerrar��5,   9   $��
25,10,20,0q�6   $	��120��6-   $��Right=�6L   $	��Top=�6j   .��5-      �� $ 
Horizontal=�6!   .+�5.      �� -
   5        $ imsage��5.       $��images/login-exit.png��60   $��15��6O   $��20��6[   �� 5/      -   5        $ 
TexstBoton��5/       $��SALIR��64   50      51      52      �� 53      -   5        $ Informacion��53      $��0��6*   $��5��6:   $��2��6G   $��Iniciando sesion...��6[   $��Center=�6y   $y�Hidden=�6�   54      55       � 	Resources 56       �� 
TargetType �� Property �� Value �� 
TargetType �� Padding �� Triggers P� Property P� Value �� 
TargetName   ComboBoxToggleButton  ��Name! F�Name  ComboBoxTextBox" �� 	ClickMode# d� 	IsChecked$ �� Path% �� Mode& �� RelativeSource' J� IsHitTestVisible( �� SelectionBoxItem) �� SelectionBoxItemTemplate* �� 
IsReadOnly+ �� 
IsReadOnly, �� IsDropDownOpen- � AllowsTransparency. J� SnapsToDevicePixels/ � ActualWidth0 �� MaxDropDownHeight1 K� IsItemsHost-  'System.Windows.Input.KeyboardNavigation2   DirectionalNavigation3 �� Triggers  BaseButtonStyle4 ��Name  BaseButtonStyleClose��%�  '��       &	  �    &	 5    '�� �    7   7  &	 ]    &	 O    �� 57   
   " ��6   .�58      ��  �@J�SnapsToDevicePixels . 64   �� 59       � ��$ Stretch=�64   �� 5:       � ��$ Stretch=�62   �� 5;       � ��$ 11(�6)   �� 5<       � ��$
 Bold"�6+   �� 5=       �@�OverridesDefaultStyle . 66   �� 5>       � �� 5?      �� 5@      " ��6&   .R�5A      �� $��Border��5B   #   $ 0q�5C   %   $��0q�5D   %   $��1q�5E   %   $ 0��5F   %   
������ 
������ ._�5J      �� $ Center=�6(   �� 5K   *   5L      5M       5N      P� 5O       �@��IsHighlighted . . �5P   "   �� $ Border��6)    � ��
 �����6T   �� 5Q   "   $ Border��6)    � ��
 � � �6S   5R      5T      5V      5W      �� 5X   
   " d�6-   .�5Y      ��  � �� 5Z      �� 5[      " d�6&   .R�5\      �  5]      �� 5^   "   �� 5_   "   $��32 �63   .+�5a      �� $  Border��5b      $��2��5c      $ 0��5d      #��z��5e      ���#6B696B$��1q�5g      �� 5h      $��0��5i      $ 0��5j      
������ 
������ $��10q�5m      F� 5n      $! Arrow��5o      $��1��5p      #��z��5q      #��z��5r      $��Center=�5s      $��Center=�5t      "����        р�[ ��[ ��ا     	5u      5v       5w      P� 5x       � {� .  . �5y   "   �� $ Border��6)    � ��
 �����6S   �� 5z   "   $ Border��6)    � ��
 �����6T   �� 5{   "    � ��
 �����6?   �� 5|   "   $ Arrow��6)    � ��
 �����6L   5}      5      5�      5�      �� 5�   
   " ��62   .R�5�      �� $  PART_ContentHost��6   |�. 6/   5�      �� 5�   
   " ��6   .�5�      ��  � ��
 �   �6+   �� 5�       � ��
 �����6,   �� 5�       � ��
 �����6+   �� 5�       �@J�SnapsToDevicePixels . 64   �� 5�       �@�OverridesDefaultStyle . 66   �� 5�       � ��$
 Auto=�6K   �� 5�       � ��$
 Auto=�6I   �� 5�       � �� . 6>   �� 5�       � ��$ 11(�6)   �� 5�       � ��$
 Bold"�6+   �� 5�       � �� 5�      �� 5�      " ��6&   .R�5�      � .+�5�      d� $��ToggleButton��5�   !   #��z��5�   !   #��z��5�   !   #��z��5�      8��  $��2��5�   !   |�.  $" Press=�5�   !   # 5�   !   �� $$ IsDropDownOpen�$% TwoWay=�& �� *TemplatedParent+5�      �� 5�      $��ContentSite��5�   !   ' .  #��z( 5�   !   #��z) 5�   !   #��z��5�   !   $��	10,3,30,3q�5�   !   $��Center=�5�   !   $��Center=�5�   !   �� 5�      $ PART_EditableTextBox��6&   8�� $��Center=�5�   !   $��Center=�5�   !   $��0,3,23,3q�5�   !   |�. $y�Hidden=�5�   !   #+ z* 5�   !   ��5�   !   Z� 5�   !   � 5�      $��Popup��5�   !   $��Bottom=�5�   !   #��z, 5�   !   - . |�.  $��Slide=�5�   !   .��5�   "   � $��DropDown��5�   #   . . #��z/ 5�   #   #��z0 5�   #   .+�5�   &   �� $  DropDownBorder��5�   )   
�������$ 0��5�   -   $��1q�5�   )   ���#6B696B5�   )   �� 5�   &   $��0,0,0,0q�63   . . .��5�   *   �� 1 . $2 	Contained=�6H   5�   '   5�   #   5�      5�       5�      P� 5�       �@��HasItems .  . �5�   "   �� $ DropDownBorder��6)    � ��$ 95��6Z   5�      P� 5�       �@��
IsGrouping . . �5�   "   ��  � �� .  6R   5�      P� 5�       �@��
IsEditable . . �5�   "   ��  � �� .  6>   �� 5�   "   $ PART_EditableTextBox��6)    � y�$ Visible=�6d   �� 5�   "   $ ContentSite��6)    � y�$ Hidden=�6X   5�      5�      5�      3 5�      5�      �� 5�   
   " ��6(   .�5�      ��  �@�FocusVisualStyle 61   Z� �� 5�       � �� �#0855846+   �� 5�       � �� �#1684ba6,   �� 5�       � ��$ 1q�60   �� 5�       � �� �#0000006+   �� 5�       � ��$ Center=�6;   �� 5�       � ��$ Center=�69   �� 5�       � ��$ 	16,3,16,3q�6(   �� 5�       � �� 5�      �� 5�      " ��6&   .R�5�      �� $  Chrome��6!   #��z��5�   !   #��z��5�   !   #��z��5�   !   . . $ 3��5�   <   ._�5�      �� $4 	Presenter��6/   #��z��6B   #��z��5�   %   #��z��5�   %   ��. #. z. 5  %   5      5     P� 5      � {� .  . �5  "   ��  � �� �#3333336?   5     P� 5      �@J�IsMouseOver . . �5  "   ��  � �� �#849e296?   �� 5	  "    � �� �#cccccc6@   �� 5
  "    � �� �#0000006?   5     P� 5      � �� . . �5  "   ��  � �� �#1ba1e26?   �� 5  "    � �� �#1ba1e26@   �� 5  "    � �� �#ffffff6?   5     P� 5      �@J�	IsFocused . . �5  "   ��  � �� �#24a53a6?   �� 5  "   $ Chrome��6)    � �� �#1ba1e26T   5     5     5     5     �� 5  
   " ��6-   .�5     ��  �@�FocusVisualStyle 61   Z� �� 5      � �� �#0855846+   �� 5      � �� �#1684ba6,   �� 5      � ��$ 1q�60   �� 5      � �� �#0000006+   �� 5       � ��$ Center=�6;   �� 5!      � ��$ Center=�69   �� 5"      � ��$ 	16,3,16,3q�6(   �� 5#      � �� 5$     �� 5%     " ��6&   .R�5&     �� $  Chrome��6!   #��z��5'  !   #��z��5(  !   #��z��5)  !   . . $ 3��5*  <   ._�5+     �� $4 	Presenter��6/   #��z��6B   #��z��5,  %   #��z��5-  %   ��. #. z. 5/  %   50      51     P� 52      � {� .  . �53  "   ��  � �� �#3333336?   54     P� 55      �@J�IsMouseOver . . �56  "   ��  � �� �#a302006?   �� 57  "    � �� �#cccccc6@   �� 58  "    � �� �#0000006?   59     P� 5;      � �� . . �5<  "   ��  � �� �#d107046?   �� 5=  "    � �� �#1ba1e26@   �� 5>  "    � �� �#ffffff6?   5?     P� 5@      �@J�	IsFocused . . �5A  "   ��  � �� �#f925256?   �� 5B  "   $ Chrome��6)    � �� �#1ba1e26T   5C     5E     5G     5H     5I     5p     