   M S B A M L   `   `   `  ����>  :FEI, Version=4.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:FEIFEI  5   	       FEI.frmDetallePR   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:FEI     5   	   -   5          � Title$  Detalle��5   	   $	��500��6   $	��500��6&    � Icon$ images/fei_cuadro.ico��62    � 
ResizeMode$ NoResize=�6f    � WindowStartupLocation$ CenterScreen=�6|   .��5	      � $��20,20,20,20q�6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��2* �6   .+�5   
   �� $��Tipo de comprobante:��6   $��Calibri)�6/   $��0��6D   $��0��6T   �� 5   
   -   5         ��Name$ txtTipoComprobante��5      $�� ��6.   $��0,4,0,0q�66   $��1��6G   $��0��6W   {�.  6d   �� 5   
   $��Serie-Numero:��6   $��Calibri)�6(   $��2��6=   $��0��6M   �� 5   
   -   5        $ txtSerieNumero��5      $�� ��6*   $��0,4,0,0q�62   $��3��6C   $��0��6S   {�.  6`   �� 5   
   $
��RUC:��6   $��Calibri)�6   $��0��64   $��1��6D   �� 5   
   -   5        $ txtRuc��5      $�� ��6"   $��0,4,0,0q�6*   $��1��6;   $��1��6K   {�.  6X   �� 5!   
   $��Fecha de emision:��6   $��Calibri)�6,   $��2��6A   $��1��6Q   �� 5"   
   -   5        $ txtFechaEmision��5"      $��0,4,0,0q�6,   $�� ��6=   $��3��6E   $��1��6U   {�.  6b   �� 5$   
   $��Razon Social:��6   $��Calibri)�6(   $��0��6=   $��2��6M   �� 5%   
   -   5        $ txtRazonSocial��5%      $�� ��6*   $��0,4,0,0q�62   $��1��6C   $��3��6S   $��2��6g   {�.  6t   &   System.Windows.Controls.DataGrid  5'   
   -   5          Name$ 
dgEmpresas��5'   p   $��0��6   $��3��6#   $��4��61   $��	0,20,0,20q�6E      FrozenColumnCount$ 0��6Y   	   AutoGenerateColumns	 .  
   CanUserAddRows
 .     SelectionMode$ Single=�5*         CanUserDeleteRows .     CanUserResizeRows .  
�������   HeadersVisibility$ Column=�5.         VerticalGridLinesBrush �#000000   GridLinesVisibility$
 None=�50         SelectionUnit$ FullRow=�6.   $	��250��6G   $	��100��6W      Columns 51      0  *System.Windows.Controls.DataGridTextColumn  52      ,  &System.Windows.Controls.DataGridColumn   
IsReadOnly .    MinWidth$ 90Q�6^      CanUserReorder .     Width5  /System.Windows.Controls.DataGridLengthConverter$ 4* 6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *Cs_tag_Id_SchemeId+   Header 53      �� 54      $��Tipo comprobante��6%   $
��Wrap=�6=    �� TextAlignment$ Center=�6Q   $��Center=�6h   $��Center=�6�      ElementStyle 56      �� 57      .�58      ��  �� Property �@��TextAlignment �� Value$
 Left=�6H   �� 59       � ��$
 Wrap=�6G   5:      5<        5=       . $ 90Q�6U    .  $ 4* 6z    6%   �� *	Cs_tag_Id+ 5>      �� 5?      $��Serie-Numero��6%   $
��Wrap=�69   $ Center=�6M   $��Center=�6d   $��Center=�6    5A      �� 5B      .�5C      ��  �@��TextAlignment$
 Left=�6H   �� 5D       � ��$
 Wrap=�6G   5E      5G        5I       . $ 90Q�6\    .  $ * 6�    6%   �� *Cs_tag_IssueDate+ 5J      �� 5K      $��Fecha Emision��6%   $
��Wrap=�6:   $ Center=�6N   $��Center=�6e   $��Center=�6�    5M      �� 5N      .�5O      ��  �@��TextAlignment$
 Left=�6H   5P      5R        5S       . $ 90Q�6�    .  $ * 6�    6%   �� *75Cs_tag_SUNATRetentionInformation_SUNATRetentionAmount+ 5T      �� 5U      $��Importe Retenido��6%   $
��Wrap=�6=   $ Center=�6Q   $��Center=�6h   $��Center=�6�    5W      �� 5X      .�5Y      ��  �@��TextAlignment$
 Left=�6H   �� 5Z       � ��$
 Wrap=�6G   5[      5]        5^       . $ 90Q�6~    .  $ * 6�    6%   �� *42Cs_tag_SUNATRetentionInformation_SUNATNetTotalPaid+ 5_      �� 5`      $��Importe Total��6%   $
��Wrap=�6:   $ Center=�6N   $��Center=�6e   $��Center=�6�    5b      �� 5c      .�5d      ��  �@��TextAlignment$
 Left=�6H   5e      5g      5j      �� 5k   
   -   5         ��Name$ btnXMLEnvio��5k   �   $��Descargar XML Envio��6   $��2q�61   $��0��6=   $��2��6M   $��4��6a   $��0,0,0,10q�6o   $
��Left=�6�   $��Bottom=�6�   5l      �� 5m   
   -	   5        $ btnXMLRecepcion��5m   �   $��Descargar XML Recepcion��6   $��2q�64   $��1��6@   $��2��6Q   $��4��6e   $��0,0,0,10q�6s   $��Center=�6�   $��Bottom=�6�   5o      �� 5p   
   -
   5        $ btnRepresentacionImpresa��5p   �   $��Representacion Impresa��6   $��2q�63   $��2��6?   $��2��6O   $��4��6c   $��0,0,0,10q�6q   $��Right=�6�   $��Bottom=�6�   5r      �� 5s   
   -   5        $ 
btnRemover��5s      $��Salir��6   $��2q�6"   $	��100��6.   $��1��6:   $��2��6J   $��5��6^   $��	0,20,0,10q�6l   $��Center=�6�   $��Bottom=�6�   5u      5v      5w      