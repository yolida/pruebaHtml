   M S B A M L   `   `   `  ����>  :FEI, Version=4.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:FEIFEI  5   	       FEI.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:FEI     5   	   -   5          �Name$  	main_Form��5   	    � Title$' !Facturacion Electronica Integrada��5   	    � WindowState$ 	Maximized=�64    � WindowStartupLocation$ CenterScreen=�6M   $
��1000��6s   $	��650��6�    � Icon$ images/fei_cuadro.ico��6�    � 	Resources 5	         BaseButtonStyle �� 
TargetType �� Property �� Value	 �� 
TargetType
 J� SnapsToDevicePixels �� Triggers P� Property P� Value �� 
TargetName ! ExpanderControlTemplateCustom �� CornerRadius d�Name  ToggleButtonStyle1 d� 	IsChecked �� Mode �� RelativeSource � FocusVisualStyle �� StrokeDashArray ��Name �� ContentStringFormat �� ContentStringFormat �� Padding � RowDefinitions � LayoutTransform �� Angle A�Name F�Name � ColumnDefinitions  ImageButtonStyle��%�!  &	        &	 �    &	 �    &	 $!    �� 5
   
   " ��6(   .�5      ��  �@�FocusVisualStyle 61   Z� �� 5       � �� �#1ba1e26+   �� 5       � �� �#1684ba6,   �� 5       � ��$ 1q�60   �� 5       � �� �#0000006+   �� 5       � ��$ Center=�6;   �� 5       � ��$ Center=�69   �� 5       � ��$ 	16,3,16,3q�6(   �� 5       � �� 5      �� 5      "	 ��6&   .R�5      �� $��Chrome��6!   #��z��5   !   #��z��5   !   #��z��5   !   
 . ._�5      �� $��	Presenter��6/   #��z��6@   #��z��5   %   #��z��5   %   ��. #
 z
 5   %   5        5!      P� 5"       � {� .  . �5#   "   ��  � �� �#3333336?   5$      P� 5%       �@J�IsMouseOver . . �5&   "   ��  � �� �#dddddd6?   �� 5'   "    � �� �#cccccc6@   �� 5(   "    � �� �#3333336?   5)      P� 5*       � �� . . �5+   "   ��  � �� �#1ba1e26?   �� 5,   "    � �� �#1ba1e26@   �� 5-   "    � �� �#ffffff6?   5.      P� 5/       �@J�	IsFocused . . �50   "   �� $ Chrome��6)    � �� �#1ba1e26T   51      53      55      56      �� 57   
   "	 9�6@   .R�58      �� #��z��6   #��z��6A   #��z��6u   $ 3��6�   
 . ._�59      ]� .+�5:      d� $ 
HeaderSite��6#   #��z��67   #��z��6j   $	��Top=�6�   #��z��6�   #��z��6�   #��z��6�   #��z��6  #��z��6J  #��z��6p  #��z��6�  $��1q�6C  $��0��6N  $��0��6[  #��z��6i  #��z��6�  #���  6�   6�  �� *
IsExpanded+$ TwoWay=� �� *TemplatedParent+ 5;      �� 5<      .�5=   "   ��  � �� 5>   &   �� 5?   *   .R�5@   .   �� ._�5A   2   �� $��0q�6<   
 . 
���   �$��1��6q   $	 1 2R�6�   5B   /   5C   +   5E   #   5F      5H      �� 5I      $ 
ExpandSite��6'   #��z��6;   #��z��6o   # z 6�   $��Bottom=�6�   |�.  #��z��6�   #��z��6<  $y�	Collapsed=�6_  #��z��6v  5J      5K       5L      P� 5M       �@9�
IsExpanded . . �5N      �� $ 
ExpandSite��63    � y�$ Visible=�6K   5O      P� 5P       �@9�ExpandDirection$ Right=�65   . �5Q      �� $ 
ExpandSite��67    � ��$ Right=�6O   �� 5R      $ 
HeaderSite��67    � ��$
 Left=�6O   �� 5S      $ 
HeaderSite��6.    � �� 5T      �� 5U      " d�6$   .�5V   "   ��  � �� 5W   &   �� 5X   *   "	 d�6:   .R�5Y   .   �� # z��65   ._�5Z   2   � 
������ 
 .   5[   6   �� 5\   :   $��19 �6H   �� 5]   :   $��* �6H   .+�5_   6   �  5`   :   V� 5a   >   .~�5b   B   �� $	 -90Q�6R   5c   ?   .+�5e   :   A� $ circle��6B   
�������$��Center=�6_   $��19��6|   ���	#FF333333$��Center=�6�   $��19��6�   F� 5f   :   $ arrow��6?   "����@B `� � �D @KL � z `� 	$��Center=�6h   
 .  ���	#FF333333$��2��6�   $��Center=�6�   5g   7   �� 5h   6   #��z��6G   #��z��6{   # z 6�   $��Center=�6�   $��0,4,0,0q�6�   $��1��6	  ��. 
 . $	��Top=�6L  5i   3   5j   /    5k   .   P� 5l   2    �@d�	IsChecked$
 TrueY�6O   . �5m   6   �� $ arrow��6M    � ��" ��@B  �D � �D @B � z  �D 	6`   5n   3   P� 5o   2    �@J�IsMouseOver . . �5p   6   �� $ circle��6O    � �� �	#FF5593FF6c   �� 5q   6   $ circle��6M    � �� �	#FFF3F9FF6a   �� 5r   6   $ arrow��6O    � ��
 �   �6b   5s   3   P� 5t   2    � �� . . �5u   6   �� $ circle��6O    � �� �	#FF3C77DD6c   �� 5v   6   $ circle��6X    � ��$	 1.5��6l   �� 5w   6   $ circle��6M    � �� �	#FFD9ECFF6a   �� 5x   6   $ arrow��6O    � ��
 �   �6b   5y   3   P� 5z   2    � {� .  . �5{   6   �� $ circle��6O    � �� �	#FFBCBCBC6c   �� 5|   6   $ circle��6M    � �� �	#FFE6E6E66a   �� 5}   6   $ arrow��6O    � �� �	#FF7070706b   5~   3   5�   +   5�   #   5�      5�      5�      P� 5�       �@9�ExpandDirection$ Up=�65   . �5�      �� $ 
ExpandSite��67    � ��$	 Top=�6O   �� 5�      $ 
HeaderSite��67    � ��$ Bottom=�6O   �� 5�      $ 
HeaderSite��6.    � �� 5�      �� 5�      " d�6$   .�5�   "   ��  � �� 5�   &   �� 5�   *   "	 d�6:   .R�5�   .   �� # z��65   ._�5�   2   � 
������ 
 .   5�   6   �� 5�   :   $��19 �6K   �� 5�   :   $��* �6K   .+�5�   6   �  5�   :   V� 5�   >   .~�5�   B   �� $	 180Q�6R   5�   ?   .+�5�   :   A� $ circle��6B   
�������$��Center=�6_   $��19��6|   ���	#FF333333$��Center=�6�   $��19��6�   F� 5�   :   $ arrow��6?   "����@B `� � �D @KL � z `� 	$��Center=�6h   
 .  ���	#FF333333$��2��6�   $��Center=�6�   5�   7   �� 5�   6   #��z��6G   #��z��6{   $��1��6�   # z 6�   $
��Left=�6�   $��4,0,0,0q�6  ��. 
 . $��Center=�6M  5�   3   5�   /    5�   .   P� 5�   2    �@d�	IsChecked$
 TrueY�6O   . �5�   6   �� $ arrow��6M    � ��" ��@B  �D � �D @B � z  �D 	6`   5�   3   P� 5�   2    �@J�IsMouseOver . . �5�   6   �� $ circle��6O    � �� �	#FF5593FF6c   �� 5�   6   $ circle��6M    � �� �	#FFF3F9FF6a   �� 5�   6   $ arrow��6O    � ��
 �   �6b   5�   3   P� 5�   2    � �� . . �5�   6   �� $ circle��6O    � �� �	#FF3C77DD6c   �� 5�   6   $ circle��6X    � ��$	 1.5��6l   �� 5�   6   $ circle��6M    � �� �	#FFD9ECFF6a   �� 5�   6   $ arrow��6O    � ��
 �   �6b   5�   3   P� 5�   2    � {� .  . �5�   6   �� $ circle��6O    � �� �	#FFBCBCBC6c   �� 5�   6   $ circle��6M    � �� �	#FFE6E6E66a   �� 5�   6   $ arrow��6O    � �� �	#FF7070706b   5�   3   5�   +   5�   #   5�      5�      5�      P� 5�       �@9�ExpandDirection$
 Left=�65   . �5�      �� $ 
ExpandSite��67    � ��$
 Left=�6O   �� 5�      $ 
HeaderSite��67    � ��$ Right=�6O   �� 5�      $ 
HeaderSite��6.    � �� 5�      �� 5�      " d�6$   .�5�   "   ��  � �� 5�   &   �� 5�   *   "	 d�6:   .R�5�   .   �� # z��65   ._�5�   2   � 
������ 
 .   5�   6   �� 5�   :   $��19 �6H   �� 5�   :   $��* �6H   .+�5�   6   �  5�   :   V� 5�   >   .~�5�   B   �� $ 90Q�6R   5�   ?   .+�5�   :   A� $ circle��6B   
�������$��Center=�6_   $��19��6|   ���	#FF333333$��Center=�6�   $��19��6�   F� 5�   :   $ arrow��6?   "����@B `� � �D @KL � z `� 	$��Center=�6h   
 .  ���	#FF333333$��2��6�   $��Center=�6�   5�   7   �� 5�   6   #��z��6G   #��z��6{   # z 6�   $��Center=�6�   $��0,4,0,0q�6�   $��1��6	  ��. 
 . $	��Top=�6L  5�   3   5�   /    5�   .   P� 5�   2    �@d�	IsChecked$
 TrueY�6O   . �5�   6   �� $ arrow��6M    � ��" ��@B  �D � �D @B � z  �D 	6`   5�   3   P� 5�   2    �@J�IsMouseOver . . �5�   6   �� $ circle��6O    � �� �	#FF5593FF6c   �� 5�   6   $ circle��6M    � �� �	#FFF3F9FF6a   �� 5�   6   $ arrow��6O    � ��
 �   �6b   5�   3   P� 5�   2    � �� . . �5�   6   �� $ circle��6O    � �� �	#FF3C77DD6c   �� 5�   6   $ circle��6X    � ��$	 1.5��6l   �� 5�   6   $ circle��6M    � �� �	#FFD9ECFF6a   �� 5�   6   $ arrow��6O    � ��
 �   �6b   5�   3   P� 5�   2    � {� .  . �5�   6   �� $ circle��6O    � �� �	#FFBCBCBC6c   �� 5�   6   $ circle��6M    � �� �	#FFE6E6E66a   �� 5�   6   $ arrow��6O    � �� �	#FF7070706b   5�   3   5�   +   5�   #   5�      5�      5�      P� 5�       � {� .  . �5�      �� # � ��63    � ��5�      5�      �� 5�   
   " d�6+   .�5�      ��  � �� 5�      �� 5�      "	 d�6&   .R�5�      �� # z��6!   ._�5�      � 
������ 
 .   5   "   �� 5  &   $��19 �67   �� 5  &   $��* �67   .+�5  "   �� #��z��63   #��z��6g   $��0��6�   # z 6�   $
��Left=�6�   $��10,0,0,0q�6�   ��. 
 . $��Center=�6:  $��2��6U  5     5      5     P� 5      �@d�	IsChecked$
 TrueY�6;   P� 5	      �@J�IsMouseOver . 6=   P� 5
      � �� . 6;   P� 5      � {� .  6;   5     5     5     �� 5  
   " ��6   .�5     ��  � �� 5     �� 5     "	 ��6&   .R�5     �� 5     5     5     5     .��5     � ���#D3DBDD$��0,0,0,0q�6    .+�5  
   � -   5          �Name$  gridForm��5     $��0,0,0,0q�6!    5     �� 5     $��80 �6    �� 5     $��* �6     5!     �� 5"     -   5        ! ��Name$! gridFormLeft��5"  /   $	��250 �6#   6/   �� 5#     $��* �6#   .+�5%     �� $��0��6   $��0��6$   $ ��images/fei_cuadro_logo.png��61   $
��Fill=�6U   $��	10,5,10,5q�6d   �� 5&     $��Calibri)�6   $
��Bold"�6)   $-��'FACTURACION ELECTRONICA INTEGRADA - FEI��6;   $��1��6m   $��0��6}   $��10q�6�   $��Center=�6�   $��Center=�6�   $��22(�6�   � 5'     $��0��6   $��1��6$   ���#D3DBDD.+�5(     �� 
���  ��
�������$
��Auto=�6F   $��0,0,0,0q�6v    5)     " �� Path# �� AncestorType��%|   '9�       �� 5*     " 9�6    .�5+     ��  �@9�
IsExpanded 6;   �� $" 
IsSelected� �� "# ��5,     5-     ��5.     �� 5/     "	 ��6*   .R�50     �� 51     ��53     �� 54     " ��6    .�55     ��  � �� 56  "   �� 57  &   "	 ��66   .R�58  *   �� #��z��6;   59  '   5;     5<     .@�5?     9� ���	#FF698B24#���  66   $
��Left=�6q   ��5@     �� 5B     $ �� Bullet$ 5C  "   �� 5D  &   $��images/menu_reporte.png��6,   $��24��6M   $��30��6X   $��Center=�6d   $��Center=�6�   ._�5F  "   �� % �� Padding$% 	10,10,0,0q�6,   $��Reportes��6A   $��Center=�6Q   $��Stretch=�6l   
�������$��36��6�   $	��200��6�   5G     .��5I     � $	��250��6$   ���#a1c46d.+�5J     �� -   5        $��lblItem1��5J  U   $	��250��6$   $��20,5,0,5q�61   $��0,0,0,0q�6D   
�������$	��Top=�6x   .��5K  "   �� -   5        
�������& �� TextDecorations& 5K  -   Z� .�6v   !Reporte de Factura Electrónica6�   5L     �� 5M     -   5        $��lblItem2��5M  T   $	��250��6$   $��20,5,0,5q�60   $��0,0,0,0q�6C   
�������.��5N  "   �� -   5        
�������& 5N  -   Z� .�6v   Reporte de Resumen Diario6�   5O     �� 5P     -   5        $��lblItem3��5P  V   $	��250��6%   $��20,5,0,5q�61   $��0,0,0,0q�6D   
�������.��5Q  "   �� -	   5        
�������& 5Q  -   Z� .�6v   Reporte de Boletas de Venta6�   5R     �� 5S     -
   5        $��lblItem4��5S  V   $	��250��6%   $��20,5,0,5q�61   $��0,0,0,0q�6D   
�������.��5T  "   �� -   5        
�������& 5T  -   Z� .�6t   " Reporte de Comunicación de Baja6�   5U     �� 5V     -   5        $��lblItem5��5V  V   $	��250��6%   $��20,5,0,5q�61   $��0,0,0,0q�6D   
�������.��5W  "   �� -   5        
�������& 5W  -   Z� .�6x   '%Reporte de Comprobantes de Retención6�   5X     �� 5Y     -   5        $��lblItem6��5Y  V   $	��250��6%   $��20,5,0,5q�61   $��0,0,0,0q�6D   
�������.��5Z  "   �� -   5        
�������& 5Z  -   Z� .�6v   Reporte General6�   5[     5\     5]     9� 5^     ���	#FF698B24#���  66   ��5_     �� 5`     $��36��6.   $	��149��6:   $ 5a  "   �� 5b  &   $��images/menu_facturas.png��6,   $��24��6N   $��30��6Y   $��Center=�6e   $��Center=�6�   ._�5d  "   �� $% 	10,10,0,0q�6,   $��Factura Electrónica��6@   $��Center=�6[   $��Stretch=�6v   
�������$��36��6�   $��	0,0,-24,0q�6�   5e     .��5g     � ���#a1c46d.+�5h     �� -   5        $��lblItem7��5h  U   $	��250��6$   $��20,5,0,5q�61   $��0,0,0,0q�6D   
�������$	��Top=�6y   .��5i  "   �� -   5        
�������& 5i  -   Z� .�6t   Envío a Sunat de FE6�   5j     �� 5k     -   5        $��lblItem8��5k  U   $	��250��6$   $��20,5,0,5q�61   $��0,0,0,0q�6D   
�������$	��Top=�6y   .��5l  "   �� -   5        
�������& 5l  -   Z� .�6u   !Formas de alerta y envío de FE6�   5m     5n     5o     9� 5p     ���	#FF698B24#���  66   ��5q     �� 5r     $ 5s  "   �� 5t  &   $#��images/menu_resumendiario.png��6,   $��24��6S   $��30��6^   $��Center=�6j   $��Center=�6�   ._�5v  "   �� $% 	10,10,0,0q�6,   $��Resumen diario��6@   $��Center=�6V   $��Stretch=�6q   
�������$��36��6�   $	��150��6�   5w     .��5y     � ���#a1c46d.+�5z     �� -   5        $��lblItem9��5z  U   $	��250��6$   $��20,5,0,5q�61   $��0,0,0,0q�6D   
�������$	��Top=�6y   .��5{  "   �� -   5        
�������& 5{  -   Z� .�6|   Generar resumen diario6�   5|     �� 5}     -   5        $��	lblItem10��5}  U   $	��250��6$   $��20,5,0,5q�61   $��0,0,0,0q�6D   
�������$	��Top=�6z   .��5~  "   �� -   5        
�������& 5~  -   Z� .�6z   (&Envío a Sunat y consulta Ticket de RC6�   5     �� 5�     -   5        $��	lblItem11��5�  U   $	��250��6$   $��20,5,0,5q�61   $��0,0,0,0q�6D   
�������$	��Top=�6z   .��5�  "   �� -   5        
�������& 5�  -   Z� .�6{   !Formas de alerta y envío de RC6�   5�     5�     5�     9� 5�     ���	#FF698B24#���  66   ��5�     �� 5�     $ 5�  "   �� 5�  &   $'��!images/menu_comunicacion_baja.png��6,   $��24��6W   $��30��6b   $��Center=�6n   $��Center=�6�   ._�5�  "   �� $% 	10,10,0,0q�6,   $��Comunicación de baja��6@   $��Center=�6\   $��Stretch=�6w   
�������$��36��6�   $	��150��6�   5�     .��5�     � ���#a1c46d.+�5�     �� -   5        $��	lblItem12��5�  U   $	��250��6$   $��20,5,0,5q�61   $��0,0,0,0q�6D   
�������$	��Top=�6z   .��5�  "   �� -   5        
�������& 5�  -   Z� .�6{   Generar comunicación de baja6�   5�     �� 5�     -   5        $��	lblItem13��5�  U   $	��250��6$   $��20,5,0,5q�61   $��0,0,0,0q�6D   
�������$	��Top=�6z   .��5�  "   �� -   5        
�������& 5�  -   Z� .�6y   (&Envío a Sunat y consulta Ticket de RA6�   5�     5�     5�     9� 5�     ���	#FF698B24#���  66   ��5�     �� 5�     $ 5�  "   �� 5�  &   $��images/menu_retention.png��6,   $��24��6O   $��30��6Z   $��Center=�6f   $��Center=�6�   ._�5�  "   �� $% 	10,10,0,0q�6,   $��Comprobante de retención��6@   $��Center=�6`   $��Stretch=�6{   
�������$��36��6�   $	��170��6�   5�     .��5�     � ���#a1c46d.+�5�     �� -   5        $��	lblItem14��5�  U   $	��250��6$   $��20,5,0,5q�61   $��0,0,0,0q�6D   
�������$	��Top=�6z   .��5�  "   �� -   5        
�������& 5�  -   Z� .�6v   Envío a Sunat de CRE6�   5�     �� 5�     -    5        $��	lblItem15��5�  U   $	��250��6$   $��20,5,0,5q�61   $��0,0,0,0q�6D   
�������$	��Top=�6z   .��5�  "   �� -!   5        
�������& 5�  -   Z� .�6x   " Formas de alerta y envío de CRE6�   5�     5�     5�     9� 5�     ���	#FF698B24#���  66   ��5�     �� 5�     $ 5�  "   �� 5�  &   $'��!images/menu_comunicacion_baja.png��6,   $��24��6W   $��30��6b   $��Center=�6n   $��Center=�6�   ._�5�  "   �� $% 	10,10,0,0q�6,   $&�� Resumen Diario de Reversión CRE��6@   $��Center=�6g   $��Stretch=�6�   
�������$��36��6�   $	��200��6�   5�     .��5�     � ���#a1c46d.+�5�     �� -"   5        $��	lblItem28��5�  U   $	��250��6$   $��20,5,0,5q�61   $��0,0,0,0q�6D   
�������$	��Top=�6z   .��5�  "   �� -#   5        
�������& 5�  -   Z� .�6x   Generar reversión de CRE6�   5�     �� 5�     -$   5        $��	lblItem29��5�  U   $	��250��6$   $��20,5,0,5q�61   $��0,0,0,0q�6D   
�������$	��Top=�6z   .��5�  "   �� -%   5        
�������& 5�  -   Z� .�6v   $"Envío Sunat y Consulta Ticket CRE6�   5�     5�     5�     9� 5�     ���	#FF698B24#���  66   ��5�     �� 5�     $ 5�  "   �� 5�  &   $��images/menu_compras.png��6,   $��24��6M   $��30��6X   $��Center=�6d   $��Center=�6�   ._�5�  "   �� $% 	10,10,0,0q�6,   $��Receptor de Compras��6@   $��Center=�6[   $��Stretch=�6v   
�������$��36��6�   $	��200��6�   5�     .��5�     � ���#a1c46d.+�5�     �� -&   5        $��	lblItem30��5�  U   $	��250��6$   $��20,5,0,5q�61   $��0,0,0,0q�6D   
�������$	��Top=�6z   .��5�  "   �� -'   5        
�������& 5�  -   Z� .�6v   Validar XML6�   5�     �� 5�     -(   5        $��	lblItem31��5�  U   $	��250��6$   $��20,5,0,5q�61   $��0,0,0,0q�6D   
�������$	��Top=�6z   .��5�  "   �� -)   5        
�������& 5�  -   Z� .�6w   Registro de compras6�   5�     5�     5�     9� 5�     ���	#FF698B24#���  66   ��5�     �� 5�     $ 5�  "   �� 5�  &   $#��images/menu_configuracion.png��6,   $��24��6S   $��30��6^   $��Center=�6j   $��Center=�6�   ._�5�  "   �� $% 	10,10,0,0q�6,   $ ��Configuración del sistema��6@   $��Center=�6a   $��Stretch=�6|   
�������$��36��6�   $	��150��6�   5�     .��5�     � ���#a1c46d.+�5�     �� -*   5        $��	lblItem16��5�  U   $	��250��6$   $��20,5,0,5q�61   $��0,0,0,0q�6D   
�������$	��Top=�6z   .��5�  "   �� -+   5        ' ��Name$' btnConfigurarDB��5�  ,   
�������& 6F   Z� .�6�   !Configuración de base de datos6�   5�     �� 5�     -,   5        $��	lblItem18��5�  U   $	��250��6$   $��20,5,0,5q�61   $��0,0,0,0q�6D   
�������$	��Top=�6z   .��5�  "   �� --   5        
�������& 5�  -   Z� .�6|   Información del declarante6�   5�     �� 5�     -.   5        $��	lblItem19��5�  U   $	��250��6$   $��20,5,0,5q�61   $��0,0,0,0q�6D   
�������$	��Top=�6z   .��5�  "   �� -/   5        
�������& 5�  -   Z� .�6|   
Usuarios6�   5�     �� 5�     -0   5        $��	lblItem20��5�  U   $	��250��6$   $��20,5,0,5q�61   $��0,0,0,0q�6D   
�������$	��Top=�6z   .��5�  "   �� -1   5        
�������& 5�  -   Z� .�6}   Permisos de usuario6�   5�     5�     5�     9� 5�     ���	#FF698B24#���  66   ��5�     �� 5�     $ 5�  "   �� 5�  &   $��images/menu_utilities.png��6,   $��24��6O   $��30��6Z   $��Center=�6f   $��Center=�6�   ._�5�  "   �� $% 	10,10,0,0q�6,   $��Utilitarios��6@   $��Center=�6S   $��Stretch=�6n   
�������$��36��6�   $	��150��6�   5�     .��5�     � ���#a1c46d.+�5�     �� -2   5        $��	lblItem21��5�  U   $	��250��6$   $��20,5,0,5q�61   $��0,0,0,0q�6D   
�������$	��Top=�6z   .��5�  "   �� -3   5        
�������& 5�  -   Z� .�6~   Generación de backup6�   5�     �� 5�     -4   5        $��	lblItem22��5�  U   $	��250��6$   $��20,5,0,5q�61   $��0,0,0,0q�6D   
�������$	��Top=�6z   .��5�  "   �� -5   5        
�������& 5�  -   Z� .�6   Restauración de backup6�   5�     �� 5�     -6   5        $��	lblItem23��5�  U   $	��250��6$   $��20,5,0,5q�61   $��0,0,0,0q�6D   
�������$	��Top=�6z   .��5�  "   �� -7   5        
�������& 5�  -   Z� .�6y   Ruta de archivos6�   5      �� 5     -8   5        $��	lblItem24��5  U   $	��250��6$   $��20,5,0,5q�61   $��0,0,0,0q�6D   
�������$	��Top=�6z   .��5  "   �� -9   5        
�������& 5  -   Z� .�6   Actualización de estructuras6�   5     �� 5     -:   5        $��	lblItem32��5  U   $	��250��6$   $��20,5,0,5q�61   $��0,0,0,0q�6D   
�������$	��Top=�6z   .��5  "   �� -;   5        
�������& 5  -   Z� .�6z   Transferencia de datos6�   5     �� 5     -<   5        $��	lblItem25��5  U   $	��250��6$   $��20,5,0,5q�61   $��0,0,0,0q�6D   
�������$	��Top=�6z   .��5  "   �� -=   5        
�������& 5  -   Z� .�6}   Activación de Licencia6�   5	     5     5     9� 5     ���	#FF698B24#���  66   ��5     �� 5     $ 5  "   �� 5  &   $��images/menu_help.png��6,   $��24��6J   $��30��6U   $��Center=�6a   $��Center=�6~   ._�5  "   �� $% 	10,10,0,0q�6,   $��Ayuda��6@   $��Center=�6M   $��Stretch=�6h   
�������$��36��6�   $	��150��6�   5     .��5     � ���#a1c46d.+�5     �� ->   5        $��	lblItem26��5  U   $	��250��6$   $��20,5,0,5q�61   $��0,0,0,0q�6D   
�������$	��Top=�6z   .��5  "   �� -?   5        
�������& 5  -   Z� .�6m   Ayuda6u   5     �� 5     -@   5        $��	lblItem27��5  U   $	��250��6$   $��20,5,0,5q�61   $��0,0,0,0q�6D   
�������$	��Top=�6z   .��5  "   �� -A   5        
�������& 5  -   Z� .�6p   Acerca de FEI6   5     �� 5     -B   5        $��	lblItem33��5  U   $	��250��6$   $��20,5,0,5q�61   $��0,0,0,0q�6D   
�������$	��Top=�6z   .��5  "   �� -C   5        
�������& 5  -   Z� .�6z   Certificado Digital6�   5     5#     5$     5&     5'     � 5(     
�������$��1��6'   $��1��67   $��2��6D   $��0,0,0,0q�6V    5)     �� 5*     $��* �6$   �� 5+     $
��Auto �6$    5-     �� 5.     $��* �6'   .+�55     �� -D   5        ( ��Name$( image��55  5   $��0��6   $��0��6(   $��160,58,160,68q�6D   $��images/marca_agua_fei.png��6[   $��Uniform=�6~   ) K� ZIndex$	) -10��6�    � 56     -E   5        *  �Name$* pageContainer��56  8   $��0��6   $��0��6*   
������ $��Stretch=�6i   $��Stretch=�6�   +  � NavigationUIVisibility$+ Hidden=�6�   � 57     $��0��6   $��1��6)   ���#d3dbdd 58     �� 59     $��* �6(    5;     �� 5<     $��1* �6+   �� 5=     $��3* �6+   �� 5>     $��1* �6+   �� 5?     $
��1.5* �6+   �� 5@     $��1* �6+   .+�5B     �� $��0��6   $��0��6,   $��2��69   $��	Empresa: ��6M   $
��Left=�6a   $��Center=�6�   $
��Bold"�6�   �� 5C     -F   5        , ��Name$, 
lblEmpresa��5C  M   $��1��6   $��0��6,   $��2��69   $
��Left=�6a   $��Center=�6�   �� 5D     $��2��6   $��0��6,   $��	Usuario: ��69   $
��Left=�6M   $��Center=�6o   $
��Bold"�6�   �� 5E     -G   5        $, 
lblUsuario��5E  9   $��3��6   $��0��6,   $
��Left=�6M   $��Center=�6o   �� 5F     -H   5        - ��Name$- btnCerrarSesion��5F     $��0,5,20,5q�67   $��Right=�6J   $��4��6f   $��0��6v   $
��Bold"�6�   .��5G     �� . �� Orientation$. 
Horizontal=�6%   .+�5H     �� -I   5        $( imageButton��5H  $   $��images/logout.png��69   $��15��6T   $��15��6`   �� 5I     -J   5        $, 	TextBoton��5I  $   $��Cerrar sesión��67   5J     5K     5L     5N     5P     5Q     5S     