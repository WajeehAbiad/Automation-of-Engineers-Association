   M S B A M L   `   `   `  ����J  FWpfApplication4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication4WpfApplication4  5   	   $    WpfApplication4.Engineers_View   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WpfApplication4     5   	     � Title$  Engineers View��5   	   $	��728��6    $	��700��6-    � WindowStyle$
 None=�69    � WindowStartupLocation$ CenterScreen=�6L    � AllowsTransparency . 
������  � 	Resources 5	       !  RadioButton.Static.Background �� Color  RadioButton.Static.Border  OptionMarkFocusVisual �� Property �� Value J� SnapsToDevicePixels	 �� StrokeDashArray $  RadioButton.MouseOver.Background   RadioButton.MouseOver.Border  RadioButton.MouseOver.Glyph # RadioButton.Disabled.Background  RadioButton.Disabled.Border  RadioButton.Disabled.Glyph "	 RadioButton.Pressed.Background 
 RadioButton.Pressed.Border  RadioButton.Pressed.Glyph  RadioButton.Static.Glyph  RadioButtonStyle
 �� 
TargetType  FocusVisual �� 
TargetType �Name � ColumnDefinitions ��Name �� CornerRadius �� EndPoint �� 
StartPoint � Color � Offset A�Name J� Opacity �� Triggers P� Property P� Value �� 
TargetName��%�
  &	        &	 #     &	 F     &	 �     &	     &	 =    &	 `    &	 �    &	 �    &		 �    &	
 �    &	     &	 2    &	 U    7  7   7  7  7  7  7  7  7  7  7  7 	 7 
 7  �� 5
   
   $ 	#FFFFFFFF��6@   �� 5   
   $ 	#FF707070��6<   �� 5   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��14,0,0,0q�6$    . #��� ��6Q   $��1��6�   $		 1 2R�6�   5      5      5      �� 5   
   $ 	#FFF3F9FF��6C   �� 5   
   $ 	#FF5593FF��6?   �� 5   
   $ 	#FF212121��6>   �� 5   
   $ 	#FFE6E6E6��6B   �� 5   
   $ 	#FFBCBCBC��6>   �� 5   
   $ 	#FF707070��6=   �� 5   
   $ 	#FFD9ECFF��6A   �� 5   
   $ 	#FF3C77DD��6=   �� 5   
   $ 	#FF212121��6<   �� 5   
   $ 	#FF212121��6;   �� 5   
   "
 	�6)   .�5       ��  �@�FocusVisualStyle8   61   �� 5!       � ��8  6+   �� 5"       � ��8  6,   �� 5#       � ��# � ��6+   �� 5$       � ��$ 1q�60   �� 5%       � �� 5&      �� 5'      " 	�6&   .R�5(      � $ templateRoot��6   
������  .  5)      �� 5*   "   $
��Auto �63   �� 5+   "   $��* �63   .+�5-      �� $ radioButtonBorder��6%   #��z��6@   #��z��6l   $	 100��6�   #��z��6�   $��1,1,2,1q�6�   #��z��6  ��5.   "   �� 5/   &   $ 0.5,1&�6:   $ 0.5,0&�6K   .��50   *   � $ Black��67   $ 0Q�6E   � 51   *   $ White��67   $ 1Q�6E   52   '   ._�54   "   � $ markGrid��6'   $��2q�69   $��10��6D   $��10��6P   .+�55   &   A� $ 
optionMark��6.   8�� $��6��6s   $��6��6�   $ 0Q�6�   56   #   57      58       59      P� 5:       � �� . . �5;   "   �� 8   �@�FocusVisualStyle6E   �� 5<   "    � ��$ 4,-1,0,0q�6<   5=      P� 5>       �@J�IsMouseOver . . �5?   "   �� $ radioButtonBorder��6?   8   � ��6^   �� 5@   "   $ radioButtonBorder��6@   8   � ��6_   �� 5A   "   $ 
optionMark��69   8   � ��6Q   5B      P� 5C       � {� .  . �5D   "   �� $ radioButtonBorder��6?   8   � ��6^   �� 5E   "   $ radioButtonBorder��6@   8 	  � ��6_   �� 5F   "   $ 
optionMark��69   8 
  � ��6Q   5G      P� 5H       � �� . . �5I   "   �� $ radioButtonBorder��6?   8   � ��6^   �� 5J   "   $ radioButtonBorder��6@   8   � ��6_   �� 5K   "   $ 
optionMark��69   8   � ��6Q   5L      P� 5M       �@d�	IsChecked$
 trueY�6;   . �5N   "   �� $ 
optionMark��6<    �@J�Opacity$ 1Q�6T   5O      P� 5P       6;   Z�  �@d�	IsChecked. �5Q   "   �� $ 
optionMark��6<    �@J�Opacity$
 0.56Q�6T   5R      5T      5V      5W      5X      .��5Y      � .+�5Z   
   �� ���	#FF0097FF$ 22��6)   $��2q�6;   ._�5[      ��  �� RadiusY$ 21��6    �� RadiusX$ 21��6%   
���   �$��0��6A     RectangleStyle#���  6U   5\      �� 5]   
   -   5         ��Name$ Logo_png��5]      $��10,7,0,0q�6"   $��Logo.png��64   $
��Fill=�6F   $��35��6U   $	��Top=�6a   $
��Left=�6y   $��35��6�   �� 5^   
   -   5         ��Name$ textBlock_All_Engineers��5^        TextBlockStyle#���  65   $��All Engineers��6^   $��Right=�6s   $	��Top=�6�   ���	#FFEEB34B$��0,121.499,63.288,0q�6�   $��48(�6�   � 5`   
   $��Right=�6   $��30��6+   $��0,10,10.831,0q�67   $	��Top=�6N   $��55��6f   .+�5a      �� -   5         ��Name$ Button_Close��5a        ButtonControlTemplate_Close#���  6+   $��25,0,0,0q�6d   6v   �� 5b      -   5        $ Button_Minimize��5b       " ButtonControlTemplate_Minimize#���  6.   $
��Left=�6j   $��	0,13,0,12q�6�   $��20��6�   6�   5c      &   System.Windows.Controls.DataGrid  5e   
   -   5          Name$ dataGrid��5e      $��10,184.063,10,163.468q�6%     HeaderStyle    ColumnHeaderStyle#  [ 6D     DataGridRowStyle!   RowStyle#! [ 6u     DataGridCellStyle"   	CellStyle#" �  6�     DataGridStyle#���  6�   
������ ���	#FF0097FF$��2q�6,  � 5f   
   $��100,0,100,77.5q�6   $��50��6'   $	��500��63   $��Bottom=�6?   $��Center=�6Z   # � RowDefinitions# 5g      �� 5h      $��50 �6     5k      �� 5l      $	��250 �6#   �� 5m      $	��250 �6#   �� 5n      $	��250 �6#   .+�5q      �� -   5        $ 
Button_Add��5q         ButtonControlTemplate_Normal#���  6.   $��0��6h   $��1��6x   $	��Add��6�   $��45��6�   $��0,2.5q�6�   6�   �� 5r      -   5        $ Button_View��5r      #���  6.   $��1��6h   $��1��6x   $
��View��6�   $��45��6�   $��0,2.5q�6�   6�   5t      �� 5u   
   -   5        $* $Button_Deleted_and_Delayed_Engineers��5u       ) %ButtonControlTemplate_with_long_phase#���  6?   $��0��6�   $#��Deleted and Delayed Engineers��6�   $��45��6�   $��98.5,0,101.5,30q�6�   $��Bottom=�6  $��Center=�6F  $	��500��6c  � 5v   
   $
��Left=�6   $��94.319��6*   $	��Top=�6:   $��266.604��6R   $��52.5,84.744,0,0q�6b   .+�5w      �� -	   5        $% textBlock_Search_By_Engineer_ID��5w      #���  6A   $��Search By Engineer ID��6k   $��Stretch=�6�   $��25,0,30.044,0q�6�   $	��Top=�6�   �� 5x      -
   5        $' !textBlock_Search_By_Engineer_Name��5x      #���  6C   $��Search By Engineer Name��6m   $��Stretch=�6�   $��25,33.78,0,31.759q�6�   $��Stretch=�6�   	� 5z      -   5        $ 	�Name$$ RB_ID��5z      $��RadioButton��6)   $��0,6.047,0,0q�6?   $	��Top=�6U   $
��Left=�6m   #���  6�   $��20��6�   $��20��6�   	� 5{      -   5        $$ RB_Name��5{      $��RadioButton��6+   $��0,40.047,0,34.272q�6A   $
��Left=�6\   #���  6w   $��20��6�   �� 5}      -   5        % ��Name$% textBox_Search��5}        TextBoxStyle#���  6.   $��0,0,2.001,0q�6V   $
��Auto��6l   $��29.272��6y   $��Bottom=�6�   6�   5      5�      5�      