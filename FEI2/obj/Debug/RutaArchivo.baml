   M S B A M L   `   `   `  ����>  :FEI, Version=4.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:FEIFEI  5   	       FEI.RutaArchivo   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:FEI     5   	   -   5        $��12(�5      $��Calibri)�62     � Title$  Ruta de Archivos��5   	   $	��300��6"   $	��310��62   $	��300��6B    � 
ResizeMode$ NoResize=�6N    � WindowStartupLocation$ CenterScreen=�6d    � Icon$ images/fei_cuadro.ico��6�   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��1* �6   .+�5   
   �� $��0,10,0,0q�6   $��1��6"   $��4��62   $��0��6F   $ ��images/fei_cuadro_logo.png��6S   �� 5   
   $��Stretch=�6   $��1��65   $��4��6E   $��1��6Y   $��0,0,0,0q�6f   .��5      �� $
��Wrap=�6    �� TextAlignment$ Justify=�6,   $��12(�6D   [YLos archivos generados se estan guardando en la siguiente ubicacion, bajo la carpeta FEI.5      5      �� 5    
   -   5         ��Name$
 ruta��5       $�� ��6   $��Center=�6)   $��1��6M   $��4��6]   $��2��6q   �� 5!   
   $��Stretch=�6   $��1��65   $��4��6E   $��3��6Y   $��0,0,0,0q�6f   .��5"      �� $
��Wrap=�6   $ Justify=�6,   $��12(�6D   ^\Si desea modificar , debe tener presente que las configuraciones ya realizadas se perderán.5$      5%      �� 5&   
   -   5         ��Name$ btnModificar��5&      $��1��6'   $��0,15,0,0q�67   $��70��6I   $
��Left=�6T   $��2��6o   $��4��6�   $��	Modificar��6�   6�   �� 5'   
   -   5        $ btnResetear��5'      $��3��6&   $��0,15,0,0q�66   $��70��6H   $��Right=�6S   $��2��6o   $��4��6�   $��Resetear��6�   6�   5(      5)      