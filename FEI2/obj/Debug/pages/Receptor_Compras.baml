   M S B A M L   `   `   `  ����>  :FEI, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:FEI.pages	FEI.pages  5           FEI.pages.Receptor_Compras   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:FEI.pages     5      X TXceed.Wpf.Toolkit, Version=3.3.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5      -   5          N� Title$  Pagina_Compras��5	       N� 
Background
 �����.��5      �� $
��Auto=�6   .��5   
   � 
������� � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $��* �6     � ColumnDefinitions 5      �� 5      $��* �6#   .+�5      �� -   5         ��Name$ label��5   1   $��0��6   $��0��6$   $��REGISTRO DE COMPRAS��6@   $��Center=�6^   $��14(�6�   $
��Bold"�6�   $��Calibri)�6�   ���#dbeaf96�   � 5      $��0��6   $��1��6#   $��0,0,0,0q�60    5      �� 5      $
��Auto �6$   �� 5      $��* �6$   �� 5      $
��Auto �6$    5      �� 5      $��* �6'   �� 5      $��* �6'   .+�5       �� $��
10,0,10,10q�6   $��0��6/   $��0��6?   ���#DBDBDB��5!      �� 5"      .��6    Buscar por fechas63   .��5$      � $��	10,1,10,1q�6    5%      �� 5&      $
��Auto �6,   �� 5'      $
��Auto �6,    5)      �� 5*      $��2* �6/   �� 5+      $��2* �6/   �� 5,      $��2* �6/   �� 5-      $��2* �6/   �� 5.      $��2* �6/   �� 5/      $��2* �6/   �� 50      $��2* �6/   �� 51      $��2* �6/   .+�53         FEI.pages.DatePickerEx  -   5          Name$ datePick_inicio��53   -   $��0��6F   $��3��6V   $��0��6j   $��0,5,5,5q�6w      calendarWithGotToTodayStyle   AlternativeCalendarStyle# [  6�     54      -   5        $ datePick_fin��54   -   $��3��6C   $��3��6S   $��0��6g   $��0,5,5,5q�6t   # [  6�   �� 56      -   5         ��Name$ Buscar��56   !   $��Right=�61   $��24��6M   $��6��6Y   $��2��6i   $��0,0,0,0q�6}   $��0��6�   .��57      ��  �� Orientation$ 
Horizontal=�6)   .+�58   "   �� $��Buscar��6(   $��	10,0,10,0q�69   $��0q�6L   59      5:      5;      5<      �� 5=      $��
10,0,10,10q�6   $��1��6/   $��0��6?   ���#DBDBDB��5>      �� 5?      .��6    Buscar por periodo64   .��5A      � $��	10,1,10,1q�6    5B      �� 5C      $
��Auto �6,   �� 5D      $
��Auto �6,    5F      �� 5G      $��2* �6/   �� 5H      $��2* �6/   �� 5I      $��2* �6/   �� 5J      $��2* �6/   �� 5K      $��2* �6/   �� 5L      $��2* �6/   .+�5N      �� -   5        	 ��Name$	 periodoMesRCompras��5N   G   $��0��6#   $��2��63   $��0,5,5,5q�6c     ComboBoxFlatStyle#��[ 6t   6�   �� 5O      -   5        $	 periodoAnioRCompras��5O   H   $��2��6$   $��2��64   $��0,5,5,5q�6e   #��[ 6v   6�   �� 5P      -   5        $" BuscarRegistroComprasPeriodo��5P   !   $��Right=�6G   $��24��6c   $��5��6o   $��0,0,0,0q�6   $��0��6�   .��5Q      �� $ 
Horizontal=�6)   .+�5R   "   �� $��Buscar��6(   $��0q�69   $��	10,0,10,0q�6E   5S      5T      5U      5V      � 5W      $��0��6   $��1��6(   $��2��65   $��	10,0,10,0q�6I    5X      �� 5Y      $
��Auto �6(   �� 5Z      $
��Auto �6(   �� 5[      $
��Auto �6(   �� 5\      $
��Auto �6(    5^      �� 5_      $��3* �6+   �� 5`      $��3* �6+   �� 5a      $��3* �6+   �� 5b      $��3* �6+   �� 5c      $��3* �6+   �� 5d      $��3* �6+   .+�5n      &   System.Windows.Controls.DataGrid  -	   5        
  Name$
 dgDocumentos��5n   {   $��	0,10,0,10q�6   $��0��62   $��0��6B   $��6��6O      FrozenColumnCount$ 0��6d      AutoGenerateColumns .     CanUserAddRows .     SelectionMode$ Single=�5q         CanUserDeleteRows .     CanUserResizeRows .  
�������   HeadersVisibility$ Column=�5u         VerticalGridLinesBrush �#000000$��9(�5v   4      GridLinesVisibility$
 None=�5w         SelectionUnit$ FullRow=�6.   $	��260��6G   $	��220��6W    � 	Resources 5x       �� Color��%�   (��       5y   .   * SystemColors.HighlightBrushKey+)(�� !     5z   .   *$"SystemColors.HighlightTextBrushKey+)�� 5y      $ #DEDCD9��6`   �� 5z      $ Black��6d   5{         Columns 5|      4  .System.Windows.Controls.DataGridTemplateColumn  5}      ,  &System.Windows.Controls.DataGridColumn   MinWidth$ 30Q�65      CanUserReorder .     CanUserResize .     Header 5~   "   �� 5   &   -
   5         ��Name$ chkAllRC��5   L   $��Center=�6/   6y      CellTemplate 5�   "   �� 5�   &   .R�5�   *   �� $��chkDiscontinue��63   -   5        $��0 2 0 0q�5�   w    d� 	IsChecked 6J   ��  �� Path$ Check�  �� Mode$  TwoWay=�6�   5�   '   !   	CellStyle! 5�   "   �� 5�   &   " �� 
TargetType*  $System.Windows.Controls.DataGridCell""  6,   .�5�   *   �� # �� Property# � ��$ �� Value$$ Center=�6P   �� 5�   *   # � ��$$ Center=�6N   5�   '   5�        5�      $ Visor��67   %   
IsReadOnly% . $ 50Q�6X    .  &   CanUserSort& . '   Width5  /System.Windows.Controls.DataGridLengthConverter$' * 6�    5�   "   �� 5�   &   .R�5�   *   �� $��VisorDocument��60   -   5        $'��!/FEI;component/images/LupaPDF.png��5�   E   $��20��6p   6   5�   '   5�      0  *System.Windows.Controls.DataGridTextColumn  5�      % . $	 100Q�6�    .  & . $' 2* 6�   1  +System.Windows.Controls.DataGridBoundColumn(   Binding( 61   �� *FechaEmision+) �� StringFormat$) {0:yyyy-MM-dd}�� 5�   "   �� 5�   &   $��Fecha de Emision��61   * �� TextAlignment$* Center=�6I   $
��Wrap=�6a   $��Center=�6u   $��Center=�6�   +   ElementStyle+ 5�   "   �� 5�   &   .�5�   *   �� # �@��TextAlignment$
$ Left=�6T   �� 5�   *   # � ��$$ Center=�6X   �� 5�   *   # � ��$
$ Wrap=�6S   5�   '   5�        5�      $	 100Q�66    .  & . $' 2* 6r    5�   "   �� 5�   &   $��Fecha Vencimiento��61   $* Center=�6J   $��Center=�6a   $��Center=�6|   $
��Wrap=�6�   ! 5�   "   �� 5�   &   ""  6,   .�5�   *   �� # � ��$ �#f2f2f26H   5�   '    5�   "   �� 5�   &   .R�5�   *   &	   Xceed.Wpf.Toolkit.DateTimeUpDown	  ,
  &Xceed.Wpf.Toolkit.Primitives.InputBase, 
  
IsReadOnly, . $��Center=�6�   $��Center=�6�   - 
  TextAlignment$- Center=�6�   $��1��6  $��0,1,0,1q�6  $��1��6%  . 	  Format$. 	ShortDate=�63  �  �Xceed.Wpf.Toolkit.Primitives.UpDownBase`1[[System.Nullable`1[[System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]/   Value/ 6>   �� *FechaVencimiento+0 �� UpdateSourceTrigger$0 PropertyChanged=�$) 
dd/MM/yyyy��63  5�   '   1   CellEditingTemplate1 5�   "   �� 5�   &   .R�5�   *   	  $��Center=�6�   $��Center=�6�   $- Center=�6�   $��1��6�   $��0,1,0,1q�6  $��1��6  $. 	ShortDate=�6   / 6>   �� *FechaVencimiento+$0 PropertyChanged=�$) 
yyyy-MM-dd��6   5�   '   5�        5�      $' * 6J   % . $ 70Q�6f    .  ( 61   �� *Tipo+ 5�   "   �� 5�   &   $��	Documento��61   $��Center=�6B   $* Center=�6]   $��Center=�6t   + 5�   "   �� 5�   &   .�5�   *   �� # �@��TextAlignment$
$ Left=�6T   �� 5�   *   # � ��$$ Center=�6X   �� 5�   *   # � ��$
$ Wrap=�6S   5�   '   5�        5�      % . $ 50Q�6]    .  & . $' * 6�   ( 61   �� *Serie+ 5�   "   �� 5�   &   $��Serie��61   $��Center=�6>   $* Center=�6Y   $��Center=�6p   + 5�   "   �� 5�   &   .�5�   *   �� # �@��TextAlignment$
$ Left=�6T   �� 5�   *   # � ��$$ Center=�6X   �� 5�   *   # � ��$
$ Wrap=�6S   5�   '   5�        5�      $ 70Q�6z    .  & . $' 2* 6�   ( 61   �� *AnioEmisionDUA+$0 PropertyChanged=� 5�   "   �� 5�   &   $��Año Emision DUA��61   $
��Wrap=�6H   $* Center=�6\   $��Center=�6s   $��Center=�6�   ! 5�   "   �� 5�   &   ""  6,   .�5�   *   �� # � ��$ �#f2f2f26H   5�   '   + 5�   "   �� 5�   &   .�5�   *   �� # �@��TextAlignment$
$ Left=�6T   �� 5�   *   # � ��$$ Center=�6X   �� 5�   *   # � ��$
$ Wrap=�6S   5�   '   5�        5�      % . $ 70Q�6^    .  & . $' 2* 6�   ( 61   �� *Numero+ 5�   "   �� 5�   &   $��Numero��61   $��Center=�6?   $* Center=�6Z   $��Center=�6q   + 5�   "   �� 5�   &   .�5�   *   �� # �@��TextAlignment$
$ Left=�6T   �� 5�   *   # � ��$$ Center=�6X   �� 5�   *   # � ��$
$ Wrap=�6S   5   '   5       5     % . $ 70Q�6h    .  & . $' * 6�   ( 61   �� *TipoDocProveedor+ 5  "   �� 5  &   $��Proveedor Doc Tipo��61   $��Center=�6K   $��Center=�6f   $* Center=�6�   $
��Wrap=�6�   + 5  "   �� 5  &   .�5	  *   �� # �@��TextAlignment$
$ Left=�6T   �� 5
  *   # � ��$$ Center=�6X   �� 5  *   # � ��$
$ Wrap=�6S   5  '   5       5     % . $ 70Q�6j    .  & . $' * 6�   ( 61   �� *NumeroDocProveedor+ 5  "   �� 5  &   $�� Proveedor Doc. Numero��61   $��Center=�6O   $��Center=�6j   $
��Wrap=�6�   $* Center=�6�   + 5  "   �� 5  &   .�5  *   �� # �@��TextAlignment$
$ Left=�6T   �� 5  *   # � ��$$ Center=�6X   �� 5  *   # � ��$
$ Wrap=�6S   5  '   5       5     % . $	 150Q�6l    .  & . $' 3* 6�   ( 61   �� *RazonSocialProveedor+ 5  "   �� 5  &   $��Proveedor Razon Social��61   $��Center=�6O   $��Center=�6j   $* Center=�6�   $
��Wrap=�6�   + 5  "   �� 5   &   .�5!  *   �� # �@��TextAlignment$
$ Left=�6T   �� 5"  *   # � ��$$ Center=�6X   �� 5#  *   # � ��$
$ Wrap=�6S   5$  '   5&       5'     % . $	 150Q�6p    .  & . $' 3* 6�   ( 61   �� *AdqGravadasBaseImponible+ 5(  "   �� 5)  &   $U��OAd. Gravados Destinadas a Operaciones Gravadas y/o Exportacion - Base Imponible��61   $��Center=�6�   $��Center=�6�   $
��Wrap=�6�   $* Center=�6�   + 5+  "   �� 5,  &   .�5-  *   �� # �@��TextAlignment$
$ Left=�6T   �� 5.  *   # � ��$$ Center=�6X   �� 5/  *   # � ��$
$ Wrap=�6S   50  '   52       53     % . $	 150Q�6f    .  & . $' 3* 6�   ( 61   �� *AdqGravadasIGV+ 54  "   �� 55  &   $J��DAd. Gravados Destinadas a Operaciones Gravadas y/o Exportacion - IGV��61   $��Center=�6}   $��Center=�6�   $* Center=�6�   $
��Wrap=�6�   + 57  "   �� 58  &   .�59  *   �� # �@��TextAlignment$
$ Left=�6T   �� 5:  *   # � ��$$ Center=�6X   �� 5;  *   # � ��$
$ Wrap=�6S   5<  '   5>       5?     $	 150Q�6�    .  & . $' 3* 6�   ( 61   �� *,*AdqGravadasBaseImponibleGravadasNoGravadas+$0 PropertyChanged=� 5@  "   �� 5A  &   $c��]Ad. Gravados Destinadas a Operaciones Gravadas y/o Exportacion y no Gravadas - Base Imponible��61   $��Center=�6�   $��Center=�6�   $* Center=�6�   $
��Wrap=�6�   ! 5C  "   �� 5D  &   ""  6,   .�5E  *   �� # � ��$ �#f2f2f26H   5F  '   + 5H  "   �� 5I  &   .�5J  *   �� # �@��TextAlignment$
$ Left=�6T   �� 5K  *   # � ��$$ Center=�6X   �� 5L  *   # � ��$
$ Wrap=�6S   5M  '   5O       5P     $	 150Q�6�    .  & . $' 3* 6�   ( 61   �� *" AdqGravadasIGVGravadasNoGravados+$0 PropertyChanged=� 5Q  "   �� 5R  &   $X��RAd. Gravados Destinadas a Operaciones Gravadas y/o Exportacion y no Gravadas - IGV��61   $��Center=�6�   $��Center=�6�   $* Center=�6�   $
��Wrap=�6�   ! 5T  "   �� 5U  &   ""  6,   .�5V  *   �� # � ��$ �#f2f2f26H   5W  '   + 5Y  "   �� 5Z  &   .�5[  *   �� # �@��TextAlignment$
$ Left=�6T   �� 5\  *   # � ��$$ Center=�6X   �� 5]  *   # � ��$
$ Wrap=�6S   5^  '   5`       5a     $	 150Q�6�    .  & . $' 3* 6�   ( 61   �� *$"AdqGravadasBaseImponibleNoGravados+$0 PropertyChanged=� 5b  "   �� 5c  &   $I��CAd. Gravados Destinadas a Operaciones  no Gravadas - Base Imponible��61   $��Center=�6|   $��Center=�6�   $* Center=�6�   $
��Wrap=�6�   ! 5e  "   �� 5f  &   ""  6,   .�5g  *   �� # � ��$ �#f2f2f26H   5h  '   + 5j  "   �� 5k  &   .�5l  *   �� # �@��TextAlignment$
$ Left=�6T   �� 5m  *   # � ��$$ Center=�6X   �� 5n  *   # � ��$
$ Wrap=�6S   5o  '   5q       5r     $	 150Q�6�    .  & . $' 3* 6�   ( 61   �� *AdqGravadasIGVNoGravados+$0 PropertyChanged=� 5s  "   �� 5t  &   $@��:Ad. Gravados Destinadas a Operaciones  y no Gravadas - IGV��61   $��Center=�6s   $��Center=�6�   $* Center=�6�   $
��Wrap=�6�   ! 5v  "   �� 5w  &   ""  6,   .�5x  *   �� # � ��$ �#f2f2f26H   5y  '   + 5{  "   �� 5|  &   .�5}  *   �� # �@��TextAlignment$
$ Left=�6T   �� 5~  *   # � ��$$ Center=�6X   �� 5  *   # � ��$
$ Wrap=�6S   5�  '   5�       5�     % . $	 100Q�6q    .  & . $' 3* 6�   ( 61   �� *ValorAdquisicionNoGravada+ 5�  "   �� 5�  &   $,��&Valor de las adquisiciones no gravadas��61   $��Center=�6_   $��Center=�6z   $* Center=�6�   $
��Wrap=�6�   + 5�  "   �� 5�  &   .�5�  *   �� # �@��TextAlignment$
$ Left=�6T   �� 5�  *   # � ��$$ Center=�6X   �� 5�  *   # � ��$
$ Wrap=�6S   5�  '   5�       5�     % . $ 50Q�6[    .  & . $' * 6�   ( 61   �� *Isc+ 5�  "   �� 5�  &   $	��ISC��61   $��Center=�6<   $��Center=�6W   $* Center=�6u   $
��Wrap=�6�   + 5�  "   �� 5�  &   .�5�  *   �� # �@��TextAlignment$
$ Left=�6T   �� 5�  *   # � ��$$ Center=�6X   �� 5�  *   # � ��$
$ Wrap=�6S   5�  '   5�       5�     % . $ 70Q�6l    .  & . $' * 6�   ( 61   �� *OtrosTributosYCargos+ 5�  "   �� 5�  &   $��OtrosTributosyCargos��61   $��Center=�6M   $��Center=�6h   $* Center=�6�   $
��Wrap=�6�   + 5�  "   �� 5�  &   .�5�  *   �� # �@��TextAlignment$
$ Left=�6T   �� 5�  *   # � ��$$ Center=�6X   �� 5�  *   # � ��$
$ Wrap=�6S   5�  '   5�       5�     % . $ 70Q�6d    .  & . $' * 6�   ( 61   �� *ImporteTotal+ 5�  "   �� 5�  &   $��Importe Total��61   $��Center=�6F   $��Center=�6a   $* Center=�6   $
��Wrap=�6�   + 5�  "   �� 5�  &   .�5�  *   �� # �@��TextAlignment$
$ Left=�6T   �� 5�  *   # � ��$$ Center=�6X   �� 5�  *   # � ��$
$ Wrap=�6S   5�  '   5�       5�     $ 70Q�6�    .  & . $' * 6�   ( 61   �� **(NumeroComprobantePagoSujetoNoDomiciliado+$0 PropertyChanged=� 5�  "   �� 5�  &   $��Sujeto No Domiciliado��61   $��Center=�6N   $��Center=�6i   $* Center=�6�   $
��Wrap=�6�   ! 5�  "   �� 5�  &   ""  6,   .�5�  *   �� # � ��$ �#f2f2f26H   5�  '   + 5�  "   �� 5�  &   .�5�  *   �� # �@��TextAlignment$
$ Left=�6T   �� 5�  *   # � ��$$ Center=�6X   �� 5�  *   # � ��$
$ Wrap=�6S   5�  '   5�       5�     $	 100Q�6}    .  & . $' 2* 6�   ( 61   �� *ConstDepDetNumero+$0 PropertyChanged=� 5�  "   �� 5�  &   $"��Constancia Detraccion Numero��61   $��Center=�6U   $��Center=�6p   $* Center=�6�   $
��Wrap=�6�   ! 5�  "   �� 5�  &   ""  6,   .�5�  *   �� # � ��$ �#f2f2f26H   5�  '   + 5�  "   �� 5�  &   .�5�  *   �� # �@��TextAlignment$
$ Left=�6T   �� 5�  *   # � ��$$ Center=�6X   �� 5�  *   # � ��$
$ Wrap=�6S   5�  '   5�       5�     $	 100Q�66    .  & . $' 2* 6r    5�  "   �� 5�  &   $!��Constancia Detraccion Fecha��61   $* Center=�6T   $��Center=�6k   $��Center=�6�   $
��Wrap=�6�   ! 5�  "   �� 5�  &   ""  6,   .�5�  *   �� # � ��$ �#f2f2f26H   5�  '    5�  "   �� 5�  &   .R�5�  *   	  $��Center=�6�   $��Center=�6�   , . $- Center=�6�   $��1��6  $��0,1,0,1q�6  $��1��6%  $. 	ShortDate=�63  / 6>   �� *ConstDepDetFecha+$0 PropertyChanged=�$) 
dd/MM/yyyy��63  5�  '   1 5�  "   �� 5�  &   .R�5�  *   	  $��Center=�6�   $��Center=�6�   $- Center=�6�   2 � ToolTip$2 False��6�   $��1��6  $��0,1,0,1q�6  $��1��6#  $. 	ShortDate=�61  / 6>   �� *ConstDepDetFecha+$0 PropertyChanged=�$) 
dd/MM/yyyy��61  5�  '   5�       5�     $ 50Q�6v    .  & . $' * 6�   ( 61   �� *
TipoCambio+$0 PropertyChanged=� 5�  "   �� 5�  &   $��Tipo de Cambio��61   $��Center=�6G   $��Center=�6b   $* Center=�6�   $
��Wrap=�6�   ! 5   "   �� 5  &   ""  6,   .�5  *   �� # � ��$ �#f2f2f26H   5  '   + 5  "   �� 5  &   .�5  *   �� # �@��TextAlignment$
$ Left=�6T   �� 5  *   # � ��$$ Center=�6X   �� 5	  *   # � ��$
$ Wrap=�6S   5
  '   5       5     $	 100Q�67    .  & . $' 2* 6s    5  "   �� 5  &   $��Fecha Doc. Ref.��61   $* Center=�6H   $��Center=�6_   $��Center=�6z   $
��Wrap=�6�   ! 5  "   �� 5  &   ""  6,   .�5  *   �� # � ��$ �#f2f2f26H   5  '    5  "   �� 5  &   .R�5  *   	  $- Center=�6�   $��Center=�6�   , . $��Center=�6�   $��1��6  $��0,1,0,1q�6  $��1��6'  $. 	ShortDate=�65  / 6>   �� *DocReferenciaFecha+$0 PropertyChanged=�$) 
dd/MM/yyyy��65  5  '   1 5  "   �� 5  &   .R�5   *   	  $- Center=�6�   $��Center=�6�   $��Center=�6�   $��1��6�   $��0,1,0,1q�6  $��1��6  $. 	ShortDate=�6#  / 6>   �� *DocReferenciaFecha+$0 PropertyChanged=�$) 
dd/MM/yyyy��6#  5#  '   5%       53     $	 100Q�6S   % .  .  & . $' 2* 6�   ( 61   �� *DocReferencia+ 54  "   �� 55  &   $��Doc. Referencia��61   $��Center=�6H   $��Center=�6c   $* Center=�6�   $
��Wrap=�6�   + 57  "   �� 58  &   .�59  *   �� # �@��TextAlignment$
$ Left=�6T   �� 5:  *   # � ��$$ Center=�6X   �� 5;  *   # � ��$
$ Wrap=�6S   5<  '   5>       5?     $ 70Q�6Y   % .  .  & . $' * 6�   ( 61   �� *DocReferenciaSerie+ 5@  "   �� 5A  &   $��Serie Doc. Ref.��61   $��Center=�6H   $��Center=�6c   $* Center=�6�   $
��Wrap=�6�   + 5C  "   �� 5D  &   .�5E  *   �� # �@��TextAlignment$
$ Left=�6T   �� 5F  *   # � ��$$ Center=�6X   �� 5G  *   # � ��$
$ Wrap=�6S   5H  '   5J       5K     $ 70Q�6Y   % .  .  & . $' * 6�   ( 61   �� *DocReferenciaNumero+ 5L  "   �� 5M  &   $��Numero Doc. Ref.��61   $��Center=�6I   $��Center=�6d   $* Center=�6�   $
��Wrap=�6�   + 5O  "   �� 5P  &   .�5Q  *   �� # �@��TextAlignment$
$ Left=�6T   �� 5R  *   # � ��$$ Center=�6X   �� 5S  *   # � ��$
$ Wrap=�6S   5T  '   5V       5W     $ 50Q�6L   % .  .  & . $' * 6�   ( 61   �� *Moneda+ 5X  "   �� 5Y  &   $��Moneda��61   $��Center=�6?   $��Center=�6Z   $* Center=�6x   $
��Wrap=�6�   + 5[  "   �� 5\  &   .�5]  *   �� # �@��TextAlignment$
$ Left=�6T   �� 5^  *   # � ��$$ Center=�6X   �� 5_  *   # � ��$
$ Wrap=�6S   5`  '   5b       5d     $ 70Q�6    .  & . $' * 6�   ( 61   �� *EquivalenteDolares+$0 PropertyChanged=� 5e  "   �� 5f  &   $��Equivalente en Dólares��61   $��Center=�6O   $��Center=�6j   $* Center=�6�   $
��Wrap=�6�   ! 5h  "   �� 5i  &   ""  6,   .�5j  *   �� # � ��$ �#f2f2f26H   5k  '   + 5m  "   �� 5n  &   .�5o  *   �� # �@��TextAlignment$
$ Left=�6T   �� 5p  *   # � ��$$ Center=�6X   �� 5q  *   # � ��$
$ Wrap=�6S   5r  '   5t       5u     $	 100Q�66    .  & . $' 2* 6r    5v  "   �� 5w  &   $��Fecha Vencimiento��61   $* Center=�6J   $��Center=�6a   $��Center=�6|   $
��Wrap=�6�   ! 5y  "   �� 5z  &   ""  6,   .�5{  *   �� # � ��$ �#f2f2f26H   5|  '    5~  "   �� 5  &   .R�5�  *   	  $- Center=�6�   , . $��Center=�6�   $��Center=�6�   $��1��6  $��0,1,0,1q�6  $��1��6*  $. 	ShortDate=�6:  / 6>   �� *FechaVencimientoDos+$0 PropertyChanged=�$) 
dd/MM/yyyy��6:  5�  '   1 5�  "   �� 5�  &   .R�5�  *   	  $- Center=�6�   $��Center=�6�   $��Center=�6�   $��1��6�   $��0,1,0,1q�6  $��1��6  $. 	ShortDate=�6'  / 6>   �� *FechaVencimientoDos+$0 PropertyChanged=�$) 
dd/MM/yyyy��6'  5�  '   5�     4  .System.Windows.Controls.DataGridComboBoxColumn  5�     3   DisplayMemberPath$3 _Value��5�  2   4   SelectedValuePath$	4 _Id��5�  2   $' 2* 6J   $	 100Q�6U   5   SelectedValueBinding5 5�  2   �� *CondicionCompra+$0 PropertyChanged=� 5�  "   �� 5�  &   $��	Condicion��61   $��Center=�6B   $��Center=�6]   $* Center=�6z   $
��Wrap=�6�   ! 5�  "   �� 5�  &   ""  6,   .�5�  *   �� # � ��$ �#f2f2f26H   5�  '   6   ElementStyle6 5�  "   �� 5�  &   "" ��6,   .�5�  *   �� # � ��$ 6H   �� $&  DataContext.ParesCondicionCompra�7 �� RelativeSource7 �� *Findancestor+8 �� AncestorType"8 N�5�  '   9   EditingElementStyle9 5�  "   �� 5�  &   "" ��6,   .�5�  *   �� # � ��$ 6H   �� $&  DataContext.ParesCondicionCompra�7 �� *Findancestor+"8 N�5�  '   5�       5�     $ 80Q�6�    .  & . $' * 6�   ( 61   �� *CtaContableBaseImponible+$0 PropertyChanged=� 5�  "   �� 5�  &   $$��Cuenta Contable Base Imponible��61   $��Center=�6W   $��Center=�6r   $* Center=�6�   $
��Wrap=�6�   ! 5�  "   �� 5�  &   ""  6,   .�5�  *   �� # � ��$ �#f2f2f26H   5�  '   + 5�  "   �� 5�  &   .�5�  *   �� # �@��TextAlignment$
$ Left=�6T   �� 5�  *   # � ��$$ Center=�6X   �� 5�  *   # � ��$
$ Wrap=�6S   5�  '   5�       5�     $ 80Q�6�    .  & . $' * 6�   ( 61   �� *CtaContableOtrosTributos+$0 PropertyChanged=� 5�  "   �� 5�  &   $$��Cuenta Contable Otros Tributos��61   $��Center=�6W   $��Center=�6r   $* Center=�6�   $
��Wrap=�6�   ! 5�  "   �� 5�  &   ""  6,   .�5�  *   �� # � ��$ �#f2f2f26H   5�  '   + 5�  "   �� 5�  &   .�5�  *   �� # �@��TextAlignment$
$ Left=�6T   �� 5�  *   # � ��$$ Center=�6X   �� 5�  *   # � ��$
$ Wrap=�6S   5�  '   5�       5�     $ 80Q�6}    .  & . $' * 6�   ( 61   �� *CtaContableTotal+$0 PropertyChanged=� 5�  "   �� 5�  &   $��Cuenta Contable Total��61   $��Center=�6N   $��Center=�6i   $* Center=�6�   $
��Wrap=�6�   ! 5�  "   �� 5�  &   ""  6,   .�5�  *   �� # � ��$ �#f2f2f26H   5�  '   + 5�  "   �� 5�  &   .�5�  *   �� # �@��TextAlignment$
$ Left=�6T   �� 5�  *   # � ��$$ Center=�6X   �� 5�  *   # � ��$
$ Wrap=�6S   5�  '   5�       5�     $ 50Q�6{    .  & . $' * 6�   ( 61   �� *CentroCostosUno+$0 PropertyChanged=� 5�  "   �� 5�  &   $��	C.Costos1��61   $��Center=�6B   $��Center=�6]   $* Center=�6{   $
��Wrap=�6�   ! 5�  "   �� 5�  &   ""  6,   .�5�  *   �� # � ��$ �#f2f2f26H   5�  '   + 5�  "   �� 5�  &   .�5�  *   �� # �@��TextAlignment$
$ Left=�6T   �� 5�  *   # � ��$$ Center=�6X   �� 5�  *   # � ��$
$ Wrap=�6S   5�  '   5�       5      $ 50Q�6{    .  & . $' * 6�   ( 61   �� *CentroCostosDos+$0 PropertyChanged=� 5  "   �� 5  &   $��	C.Costos2��61   $��Center=�6B   $��Center=�6]   $* Center=�6{   $
��Wrap=�6�   ! 5  "   �� 5  &   ""  6,   .�5  *   �� # � ��$ �#f2f2f26H   5  '   + 5	  "   �� 5
  &   .�5  *   �� # �@��TextAlignment$
$ Left=�6T   �� 5  *   # � ��$$ Center=�6X   �� 5  *   # � ��$
$ Wrap=�6S   5  '   5       5     $ 70Q�6z    .  & . $' * 6�   ( 61   �� *RegimenEspecial+$0 PropertyChanged=� 5  "   �� 5  &   $��Regimen Especial��61   $��Center=�6I   $��Center=�6d   $* Center=�6�   $
��Wrap=�6�   ! 5  "   �� 5  &   ""  6,   .�5  *   �� # � ��$ �#f2f2f26H   5  '   + 5  "   �� 5  &   .�5  *   �� # �@��TextAlignment$
$ Left=�6T   �� 5  *   # � ��$$ Center=�6X   �� 5  *   # � ��$
$ Wrap=�6S   5  '   5!       5"     % . $ 60Q�6�    .  & . $' * 6�   ( 61   �� *PorcentajeRegimenEspecial+$0 PropertyChanged=� 5#  "   �� 5$  &   $!��Procentaje Regimen Especial��61   $��Center=�6T   $��Center=�6o   $* Center=�6�   $
��Wrap=�6�   + 5&  "   �� 5'  &   .�5(  *   �� # �@��TextAlignment$
$ Left=�6T   �� 5)  *   # � ��$$ Center=�6X   �� 5*  *   # � ��$
$ Wrap=�6S   5+  '   5-       5.     % . $ 60Q�6�    .  & . $' * 6�   ( 61   �� *ImporteRegimenEspecial+$0 PropertyChanged=� 5/  "   �� 50  &   $��Importe Regimen Especial��61   $��Center=�6Q   $��Center=�6l   $* Center=�6�   $
��Wrap=�6�   + 52  "   �� 53  &   .�54  *   �� # �@��TextAlignment$
$ Left=�6T   �� 55  *   # � ��$$ Center=�6X   �� 56  *   # � ��$
$ Wrap=�6S   57  '   59       5:     $ 60Q�6�    .  & . $' * 6�   ( 61   �� *SerieDocumentoRegimenEspecial+$0 PropertyChanged=� 5;  "   �� 5<  &   $ ��Serie Doc Regimen Especial��61   $��Center=�6S   $��Center=�6n   $* Center=�6�   $
��Wrap=�6�   ! 5>  "   �� 5?  &   ""  6,   .�5@  *   �� # � ��$ �#f2f2f26H   5A  '   + 5C  "   �� 5D  &   .�5E  *   �� # �@��TextAlignment$
$ Left=�6T   �� 5F  *   # � ��$$ Center=�6X   �� 5G  *   # � ��$
$ Wrap=�6S   5H  '   5J       5K     $ 60Q�6�    .  & . $' * 6�   ( 61   �� * NumeroDocumentoRegimenEspecial+$0 PropertyChanged=� 5L  "   �� 5M  &   $"��Numero Doc. Regimen Especial��61   $��Center=�6U   $��Center=�6p   $* Center=�6�   $
��Wrap=�6�   ! 5O  "   �� 5P  &   ""  6,   .�5Q  *   �� # � ��$ �#f2f2f26H   5R  '   + 5T  "   �� 5U  &   .�5V  *   �� # �@��TextAlignment$
$ Left=�6T   �� 5W  *   # � ��$$ Center=�6X   �� 5X  *   # � ��$
$ Wrap=�6S   5Y  '   5[       5\     $	 100Q�66    .  & . $' 2* 6r    5]  "   �� 5^  &   $!��Fecha Doc. Regimen Especial��61   $* Center=�6T   $��Center=�6k   $��Center=�6�   $
��Wrap=�6�   ! 5`  "   �� 5a  &   ""  6,   .�5b  *   �� # � ��$ �#f2f2f26H   5c  '    5e  "   �� 5f  &   .R�5h  *   	  $- Center=�6�   $��Center=�6�   $��Center=�6�   $��1��6�   $��0,1,0,1q�6  $��1��6   $. 	ShortDate=�6.  , . / 6>   �� *FechaDocumentoRegimenEspecial+$0 PropertyChanged=�$) 
dd/MM/yyyy��6A  5i  '   1 5k  "   �� 5l  &   .R�5m  *   	  $- Center=�6�   $��Center=�6�   $��Center=�6�   $��1��6�   $��0,1,0,1q�6  $��1��6   $. 	ShortDate=�6-  / 6>   �� *FechaDocumentoRegimenEspecial+$0 PropertyChanged=�$) 
dd/MM/yyyy��6-  5p  '   5r       5     $ 70Q�6|    .  & . $' * 6�   ( 61   �� *CodigoPresupuesto+$0 PropertyChanged=� 5�  "   �� 5�  &   $��Codigo Presupuesto��61   $��Center=�6K   $��Center=�6f   $* Center=�6�   $
��Wrap=�6�   ! 5�  "   �� 5�  &   ""  6,   .�5�  *   �� # � ��$ �#f2f2f26H   5�  '   + 5�  "   �� 5�  &   .�5�  *   �� # �@��TextAlignment$
$ Left=�6T   �� 5�  *   # � ��$$ Center=�6X   �� 5�  *   # � ��$
$ Wrap=�6S   5�  '   5�       5�     $ 70Q�6x    .  & . $' * 6�   ( 61   �� *PorcentajeIGV+$0 PropertyChanged=� 5�  "   �� 5�  &   $��Porcentaje IGV��61   $��Center=�6G   $��Center=�6b   $* Center=�6�   $
��Wrap=�6�   ! 5�  "   �� 5�  &   ""  6,   .�5�  *   �� # � ��$ �#f2f2f26H   5�  '   + 5�  "   �� 5�  &   .�5�  *   �� # �@��TextAlignment$
$ Left=�6T   �� 5�  *   # � ��$$ Center=�6X   �� 5�  *   # � ��$
$ Wrap=�6S   5�  '   5�       5�     $	 150Q�6p    .  & . $' 2* 6�   ( 61   �� *Glosa+$0 PropertyChanged=� 5�  "   �� 5�  &   $��Glosa��61   $��Center=�6>   $��Center=�6Y   $* Center=�6w   $
��Wrap=�6�   ! 5�  "   �� 5�  &   ""  6,   .�5�  *   �� # � ��$ �#f2f2f26H   5�  '   + 5�  "   �� 5�  &   .�5�  *   �� # �@��TextAlignment$
$ Left=�6T   �� 5�  *   # � ��$$ Center=�6X   �� 5�  *   # � ��$
$ Wrap=�6S   5�  '   5�       5�     $3 _Value��5�  2   $	4 _Id��5�  2   $	 100Q�6J   $' 2* 6Y   5 5�  2   �� *CondicionPercepcion+$0 PropertyChanged=� 5�  "   �� 5�  &   $��Condicion de Percepcion��61   $��Center=�6P   $��Center=�6k   $* Center=�6�   $
��Wrap=�6�   ! 5�  "   �� 5�  &   ""  6,   .�5�  *   �� # � ��$ �#f2f2f26H   5�  '   6 5�  "   �� 5�  &   "" ��6,   .�5�  *   �� # � ��$ 6H   �� $* $DataContext.ParesCondicionPercepcion�7 �� *Findancestor+"8 N�5�  '   9 5�  "   �� 5�  &   "" ��6,   .�5�  *   �� # � ��$ 6H   �� $* $DataContext.ParesCondicionPercepcion�7 �� *Findancestor+"8 N�5�  '   5�       5�     % . $' * 6�   $	 100Q�6�    .  ( 61   �� *ImporteRegimenEspecial+$0 PropertyChanged=� 5�  "   �� 5�  &   $!��Importe de Regimen Especial��61   $��Center=�6T   $��Center=�6o   $* Center=�6�   $
��Wrap=�6�   + 5�  "   �� 5�  &   .�5�  *   �� # �@��TextAlignment$
$ Left=�6T   �� 5�  *   # � ��$$ Center=�6X   �� 5�  *   # � ��$
$ Wrap=�6S   5�  '   5�     5�     �� 5�     -   5        $ btnDescartarRCompras��5�  )   $��24��6   $��0��6H   $��2��6X   $��1��6l   $��0,0,0,5q�6y   $
��Left=�6�   $��Center=�6�   .��5�     �� $ 
Horizontal=�6%   $��Center=�6>   $��Center=�6[   .+�5�     �� $��11(�6%   $��0q�63   $��	Descartar��6?   5�     5�     �� 5�     -   5        $ CantidadCompras��5�  ^   $��4��6   $��0,5,0,5q�6,   $��2��6=   $��1��6Q   $��Right=�6w   $��Right=�6�   6�   �� 5�     $��	0,0,10,10q�6   $��0��62   $��2��6B   $��2��6V   ���#DBDBDB��5�     �� 5�     .��6$   Asignación de periodo6;   .��5�     � $��	10,1,10,1q�6    5�     �� 5�  "   $
��Auto �60    5�     �� 5�  "   $��* �63   .+�5�     ]� $��0��6*   $��0��6:   $
��Left=�6H   .+�5�  "   �� -   5        $	 periodoMesRAsignar��5�  ;   $��0��6+   $	��100��6W   $��0,5,5,5q�6c   #��[ 6t   6�   �� 5�  "   -   5        $	 periodoAnioRAsignar��5�  ;   $��1��6+   $	��100��6X   $��0,5,5,5q�6d   #��[ 6u   6�   �� 5�  "   -   5        $��2��5�  )   $��0,0,0,0q�69   $��Right=�6J   $��Center=�6�   .��5�  &   �� $ 
Horizontal=�61   $��Center=�6J   $��Center=�6g   .+�5�  *   �� $��Asignar��60   $��	10,0,10,0q�6B   $��0q�6U   5�  '   5�  #   5�     5�     5�     �� 5�     $��	0,0,10,10q�6   $��2��62   $��2��6B   $��2��6V   ���#DBDBDB��5�     �� 5      .��6$   
Exportar6.   .��5     ]� $��0��6&   $��3��66   $��2��6J   $
��Left=�6X   .+�5     �� -   5        $ btnExportar��5  %   $��24��6:   $��0,0,0,0q�6G   $
��Left=�6X   .��5  "   �� $ 
Horizontal=�6-   $��Center=�6F   $��Center=�6c   .+�5  &   �� $,��&/FEI;component/images/download-png.png��6,   $��10,0,5,0q�6\   $
��Fill=�6n   �� 5  &   $��Exportar excel��6,   $��0,0,10,0q�6E   $��0q�6X   $��Center=�6d   5  #   5	     5     5     �� 5     $��0,0,0,10q�6   $��4��61   $��2��6A   $��2��6U   ���#DBDBDB��5     �� 5     .��6$   Edición de registros6:   .��5     ]� $��0��6&   $��3��66   $��2��6J   $
��Left=�6X   .+�5     �� -   5        $ btnGrabarCambios��5  %   $��24��6?   $��0,0,0,0q�6K   $
��Left=�6\   .��5  "   �� $ 
Horizontal=�6-   $��Center=�6F   $��Center=�6c   .+�5   &   �� $)��#/FEI;component/images/save-icon.png��6,   $��10,0,5,0q�6Y   $
��Fill=�6l   �� 5!  &   $ ��Guardar cambios realizados��6,   $��0,0,10,0q�6Q   $��0q�6c   $��Center=�6o   5"  #   5#     5$     5%     5/     50     51     52     53     