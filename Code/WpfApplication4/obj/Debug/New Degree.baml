   M S B A M L   `   `   `  ����J  FWpfApplication4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication4WpfApplication4  5   	        WpfApplication4.New_Degree   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WpfApplication4     5   	     � Title$  
New_Degree��5   	   $	��400��6   $	��500��6*    � WindowStyle$
 None=�66    � WindowStartupLocation$ CenterScreen=�6I    � AllowsTransparency . 
������ .��5	      � .+�5
   
   �� ���	#FF0097FF �� CornerRadius$ 22��6)   $��2q�6;   ._�5      ��  �� RadiusY$ 21��6    �� RadiusX$ 21��6%   
���   �$��0��6A      RectangleStyle#���   6U   5      � 5   
   $��Right=�6   $��30��6+   $��0,10,10.831,0q�67   $	��Top=�6N   $��55��6f   .+�5      �� -   5         ��Name$ Button_Close��5        ButtonControlTemplate_Close#���  6+   $��25,0,0,0q�6d   6v   �� 5      -   5        $ Button_Minimize��5       " ButtonControlTemplate_Minimize#���  6.   $
��Left=�6j   $��	0,13,0,12q�6�   $��20��6�   6�   5      �� 5   
   -   5         ��Name$ Logo_png��5      $��10,7,0,0q�6"   $��Logo.png��64   $
��Fill=�6F   $��35��6U   $	��Top=�6a   $
��Left=�6y   $��35��6�   �� 5   
   -   5        	 ��Name$	 textBlock_New_Degree��5        TextBlockStyle#���  62   $��
New Degree��6\   $��Center=�6n   $	��Top=�6�   ���	#FFEEB34B$��174.096,57.626,174.096,0q�6�   $��32(�6�   � 5   
   $	��160��6   $	��400��6   
 � ColumnDefinitions
 5      �� 5      $	��171 �6#   �� 5      $	��229 �6#    � RowDefinitions 5      �� 5      $��40 �6    �� 5      $��40 �6    �� 5      $��40 �6    �� 5      $��40 �6    .+�5       �� -   5        $ 	 textBlock_Previouse_Degree��5       #���  6<   $��0��6e   $��0��6u   $��Previouse Degree:��6�   $��Stretch=�6�   $��0,3.11q�6�   $��Stretch=�6�   �� 5!      -   5        $	 textBlock_Current_Degree��5!      #���  6:   $��0��6c   $��1��6s   $��Current Degree:��6�   $��Center=�6�   $��0,3.11q�6�   $��Center=�6�   �� 5"      -   5        $	 textBlock_Next_Degree��5"      #���  67   $��0��6`   $��2��6p   $��Next Degree:��6}   $��Center=�6�   $��0,3.11q�6�   $��Center=�6�   �� 5#      -   5        $	 textBlock_Degree_Years��5#      #���  68   $��0��6a   $��3��6q   $��Degree Years:��6~   $��Center=�6�   $��0,3.11q�6�   $��Center=�6�   �� 5%      -	   5         ��Name$ comboBox_Previouse_Degree��5%        ComboBoxStyle#���  6:   $��1��6b   $��0��6r   $��1,4.508q�6   $��Center=�6�   $��Center=�6�   �� 5&      -
   5         ��Name$ textBox_Current_Degree��5&        TextBoxStyle#���  66   $��1��6^   $��1��6n   $��1,4.508,0,4.508q�6|   $	��228��6�   $��Center=�6�   $��Center=�6�   �� 5'      -   5        $ textBox_Next_Degree��5'      #���  63   $��1��6[   $��2��6k   $��1,4.508,1,10q�6y   $
��Auto��6�   �� 5(      -   5        $ textBox_Degree_Years��5(      #���  64   $��1��6\   $��3��6l   $��1,4.508,1,10q�6z   $
��Auto��6�   5*      � 5,   
   $��Center=�6   $��36.336��6,   $��100,0,100,42.832q�6<   $��Bottom=�6V   $	��300��6q   
 5-      �� 5.      $	��150 �6#   �� 5/      $	��150 �6#   .+�51      �� -   5        $ button_Save��51         ButtonControlTemplate_Normal#���  6*   $��0��6d   $
��Save��6t   6�   �� 52      -   5        $ button_Cancel��52      #���  6,   $��1��6f   $��Cancel��6v   6�   53      56      57      