   M S B A M L   `   `   `  ����H  DGroup_Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Group_Project.ViewGroup_Project.View  5   	   A%clr-namespace:Group_Project.ViewModelGroup_Project.ViewModel  5   	   )    #Group_Project.View.AddStudentWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Group_Project.View     5   	   4VM%clr-namespace:Group_Project.ViewModel     5   	   c _MaterialDesignThemes.MahApps, Version=0.3.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a_ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5   	   $��18(�5
   
     � 
ResizeMode$  NoResize=�6    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�6.    � AllowsTransparency$
 True��6A   
������ $	��645��5      $	��875��6'    � 	Resources 5       �� 
TargetType   IconBorderStyle �� Property �� Value��%�   &	        �� 5   
   " ��6   .�5      ��  � ��
 ���� 6+   �� 5       � ��
 �   �6,   �� 5       � ��$ 2q�60   �� 5       �@��CornerRadius$ 20��6-   5      5      .��5      � $��20q�6    J� Effect 5   
   3  -System.Windows.Media.Effects.DropShadowEffect  5      	   
BlurRadius$	 30Q�6   
   ShadowDepth$
 1Q�6/      Opacity$	 0.4Q�6?    � ColumnDefinitions 5    
   �� 5!      $��* �6   �� 5"      $��1.22* �6   .+�5&   
   �� ���#663399 �� CornerRadius$ 	10 0 0 10��6)   $
}�True��6B    J� Clip 5'      �� 5(       �� RadiusX$ 10Q�6$    �� RadiusY$ 10Q�61    �� Rect$ 0,0,400,605�6>   ._�5+      � .+�5-      �� $��	0 120 0 0q�6   $	��Top=�60   .+�5.      �� $��Student Manager��6    $��46(�67   $��Light"�6E   ���#ffffff �� TextAlignment$ Center=�6m   �� 5/      $��to update new students��6    $��Light"�6>   $��16(�6Q   ���#D1F2EB$ Center=�6t   �� 50      $	��and��6    $��Light"�6+   $��16(�6>   ���#D1F2EB$ Center=�6a   $��0 5 0 0q�6x   �� 51      $��Edit Students��6    $��Light"�65   $��16(�6H   ���#D1F2EB$ Center=�6k   52      A� 55      $	��500��6   $	��500��6&   $��Bottom=�63   ���#8c14fc$��50 0 0 -200q�6]    J� Opacity$	 0.6Q�6r   A� 56      $	��300��6   $	��300��6&   $��Bottom=�63   ���#8c14fc$��-450 0 0 30q�6]   $	 0.3Q�6r   A� 57      $	��400��6   $	��400��6&   $��Bottom=�63   ���#8c14fc$��-320 0 0 -120q�6]   $	 0.3Q�6t   A� 58      $	��250��6   $	��250��6&   $��Bottom=�63   ���#8c14fc$��-380 0 0 -120q�6]   A� 59      $	��400��6   $	��400��6&   $��Bottom=�63   ���#8c14fc$��280 0 0 -70q�6]   $	 0.8Q�6r   �� 5;      $��Bottom=�6   $��Center=�68   .+�5=      �� #��[  6!   $��5q�6J   
�������$ 90��6r   $��60q�6�    �� Padding$ 15q�6�   ._�5>      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ AccountStudent=�62   $	��100��6I   
������ 
�������$	��100��6�   $��Bottom=�6�   $��Center=�6�   5A      5B      5I      5J      �� 5M   
   $��1��6   ���#ffffff$ 	0 10 10 0��66   ._�5N      � .+�5R      �� $��Center=�6   .+�5S      �� $��10q�6   $��2q�6)    ) %MaterialDesignDarkSeparatorBackground#���  6=   $	��300��6�   $��50��6�   $ 5��6�   ._�5U      �� $��1q�6"   $��50��5V   "   $	��260��5W   "   $��
5,-2,12,-2q�5X   "   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Reg No��5Y         
Foreground
 � � � % !MaterialDesignFloatingHintTextBox#��[ 5^      ��5Z      �� *RegNo+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�5^      5`      �� 5a      $��10q�6   $��2q�6)   #���  6=   $	��300��6�   $��50��6�   $ 5��6�   ._�5c      �� $��1q�6"   $��50��5d   "   $	��260��5e   "   $��
5,-2,12,-2q�5f   "   $
 Name��5g      
 � � �#��[ 5l      ��5h      �� *Name+$ PropertyChanged=�$ TwoWay=�5l      5n      �� 5p      $��10q�6   $��2q�6)   #���  6=   $	��300��6�   $��50��6�   $ 5��6�   ._�5r      �� $��1q�6"   $��50��5s   "   $	��260��5t   "   $��
5,-2,12,-2q�5u   "   $	 Age��5v      
 � � �#��[ 5{      ��5w      �� *Age+$ PropertyChanged=�$ TwoWay=�5{      5}      �� 5~      $��10q�6   $ 5��6)   $	��300��6:   $��50��6F   $ 2q�6R     AttentionToActionBrush#��[ 6^   $��1q�6�   ._�5�   "   �� $ Course��6,     MaterialDesignComboBox#��[ 6T   $
��0 10q�6�   $	��280��6�   $��40��6�    �� DisplayMemberPath$ 
CourseName��6�   ��6�   �� *CoursesList+ �� SelectedValue 6�   �� *SelectedCourse+5�      5�      �� 5�       �� Orientation$ 
Horizontal=�6!   $��20q�6;   $��Center=�6G   .+�5�      ��   MaterialDesignRaisedButton#��[ 6!   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 5��6U   $
��Save��6�   ���#ffffff$��18(�6�   $��45��6�   $	��120��6�   $��
0 10 10 10q�6�   ��6�   �� *saveCommand+6�   �� 5�      $��Cancel��6!   $ 5��6T   $��16(�6�   $��45��6�   $	��120��6�   $��
10 10 0 10q�6�   ��62   �� *CancelCommand+6�   5�      5�      5�      5�      5�      5�      