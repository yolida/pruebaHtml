   M S B A M L   `   `   `  ����>  :FEI, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:FEI.CustomDialogFEI.CustomDialog  5   
   #    FEI.CustomDialog.CustomDialog   5   
   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   
   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   
   @d2http://schemas.microsoft.com/expression/blend/2008     5   
   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   
   0localclr-namespace:FEI.CustomDialog     5   
   -   5          � Title$  CustomDialog��5   
   $
��Auto��6   $	��380��6-    � SizeToContent$ Height=�5	        � WindowStartupLocation$ CenterScreen=�67   $��0,0,0,0q�5
   
    � WindowStyle$
 None=�6    J� SnapsToDevicePixels . $��Calibri)�5   !    � Icon$* $/FEI;component/images/fei_cuadro.ico��6Z    � 
ResizeMode$ NoResize=�6�   ��5	   
   Z� .��5      �� -   5         ��Name$ borderCustomDialog��5      $��2q�6?    �� CornerRadius$ 0,0,0,0��6S   	 �� Padding$	 0,0,0,0q�6j   ��6)   Z� ._�5   
   �� $��0,0,0,0q�6   $
��Auto��6&   $
��Auto��63   .+�5      �� -   5        
 ��Name$
 	tbCaption��5      $	��Top=�6+   $
��Auto��6C   $��Arial)�6Q   $��Caption��6d   $��WordEllipsis=�6s   $��NoWrap=�6�   ���	#FF000000 �� Padding$ 4,6,0,6q�6�   6�   � 5      
�������$
��Auto��6&   $
��Auto��63   $��0,-1,0,0q�6A    � ColumnDefinitions 5      �� 5      $
��Auto �6'   �� 5       � RowDefinitions 5      �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   .+�5      �� -   5         ��Name$ imgInstructionIcon��5   )   $��8,8,8,8q�6   $
��Auto��6E   $
��Auto��6R   $7��1/FEI;component/images/CustomDialogInformation.png��6`   $��1��6�   $��0��6�   �� 5      -   5        $
 tbInstructionHeading��5   K   $��Stretch=�6   $��0,0,0,0q�6:   $��Center=�6i   $
��Auto��6�   $��Instruction Heading��6�   $
��Wrap=�6�   $��1��6�   $��1��6�   $��1��6�   $��18(�6�   ���	#FF006ECD6  �� 5      -   5        $
 tbInstructionText��5   L   $��0,0,20,0q�6   $��Stretch=�6.   $
��Auto��6g   $��Instruction��6t   $
��Wrap=�6�   $��1��6�    �� TextAlignment$ Justify=�6�   $��1��6�   $��1��6�   $��1��6�   $��12(�6�   �� 5       -   5         ��Name$ tbAdditionalDetailsText��5    K    �� 
IsReadOnly .  �� IsReadOnlyCaretVisible . $��50��6l   $	��100��6{   $y�	Collapsed=�6�   $��Stretch=�6�    �� TextWrapping$
 Wrap=�6�   $��	0,10,20,0q�6�   $��1��6�   $��11(�6�   $��2��6  $��Disabled=�6  $
��Auto=�6H  .��6x  5!      �� 5"      $��0,10,0,0q�6   $	��Top=�6+   $
��Auto��6C   ���	#FFECECEC���	#FFC9C9C9$��0,1,0,1q�6�   $	 8,0,0,0q�6�   $��2��6�   $��3��6�   ._�5#      ]� $��0,8,12,8q�6    $
��Auto��62   $
��Auto��6?   ��6M   Z� .+�5$      9� -   5         9�Name$ expAdditionalDetails��5$   k   }�.  $��11(�68   $
��Left=�6P   $��Center=�6�   $��Arial)�6�   $��Ver Detalles��6�   .��5%      � $��0,0,0,0q�6#   $
��Auto��64   5&      �� 5'      -	   5         ��Name$ 	btnCancel��5'   !   $��60��65   $
��Auto��6@   $��Cancel��6N   $��Right=�6_   $��0,0,8,0q�6{   $��Center=�6�   $��Right=�6�   6�   �� 5)      -
   5        $ btnNo��5)   !   $��60��60   $
��Auto��6;   $��No��6I   $��Right=�6V   $��0,0,8,0q�6r   $��Center=�6�   $��Right=�6�   6�   �� 5+      -   5        $ btnYes��5+   !   $��60��61   $
��Auto��6<   $	��Yes��6J   $��Right=�6X   $��0,0,8,0q�6t   $��Center=�6�   $��Right=�6�   6�   �� 5-      -   5        $ btnOK��5-   !   $��60��60   $
��Auto��6;   $��OK��6I   $��Right=�6V   $��0,0,8,0q�6r   $��Center=�6�   $��Right=�6�   6�   � 5/      -   5         �Name$" pbDisabledButtonsProgressBar��5/   T   $��Right=�6&   $��0,0,10,0q�6B   $��75��6z   $��10��6�   $��Right=�6�    � SmallChange$ 1Q�6�   51      52      �� 53      $��Stretch=�6   $��0,0,0,0q�67   $
��Auto��6H   ���	#FFECECEC���	#FFF4F4F4$��0,1,0,0q�6�   $��2��6�   $��4��6�   $��1��6�   ._�54      �� $
��Auto��6!    �� Orientation$ 
Horizontal=�6/   .+�55      �� -   5        $ imgFooterIcon��55   [    J� RenderTransformOrigin$ 0.5,0.5&�6    $
��Left=�6@   $��Center=�6r   $
��Auto��6�   $
��Auto��6�   $7��1/FEI;component/images/CustomDialogInformation.png��6�   z�56      V� 57   "   .~�58   &   ��  �� ScaleX$	 0.5Q�65    �� ScaleY$	 0.5Q�6B   �� 59   &    �� AngleX$ 0Q�64    �� AngleY$ 0Q�6?   �� 5:   &    �� Angle$ 0Q�66   T� 5;   &    T� X$ 0Q�69     T� Y$  0Q�6?   5<   #   5>      �� 5?      -   5        $
 tbFooterText��5?   B   $��Stretch=�6$   $��Center=�6X   $��Arial)�6s   $��Footer Text��6�   $
��Wrap=�6�   5@      5A      5B      5C      5D      5E      