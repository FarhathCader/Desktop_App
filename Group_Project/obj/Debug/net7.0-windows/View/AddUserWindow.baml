   M S B A M L   `   `   `  ����H  DGroup_Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Group_Project.ViewGroup_Project.View  5   	   A%clr-namespace:Group_Project.ViewModelGroup_Project.ViewModel  5   	   &     Group_Project.View.AddUserWindow   5   
   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Group_Project.View     5   	   4VM%clr-namespace:Group_Project.ViewModel     5   	   c _MaterialDesignThemes.MahApps, Version=0.3.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a_ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5      RmaterialDesignConverters1http://materialdesigninxaml.net/winfx/xaml/shared   5   	     � WindowStartupLocation$  CenterScreen=�5	   	    � WindowStyle$
 None=�5
   	    � AllowsTransparency$
 True��5   	   
������ $	��500��5   	   $	��800��5   	    � 	Resources 5       �� 
TargetType   IconBorderStyle �� Property �� Value��%�   &	        �� 5   
   " ��6   .�5      ��  � ��
 ���� 6+   �� 5       � ��
 �   �6,   �� 5       � ��$ 2q�60   �� 5       �@��CornerRadius$ 20��6-   5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��1.5* �6   .+�5"   
   ��  �� CornerRadius$ 	10 0 0 10��6   ���#8c14fc._�5%      � .+�5&      �� .+�5'      � 	 � Points	 �    -1��� ;X�����#6633996:   � 5(      '	 �    �� �� ���� ��
�����#6633996?   A� 5)      $��250 450 0 0q�6   $��40��63   $��40��6>   ���#6633996J   A� 5*      $��
50 400 0 0q�6   $��20��62   $��20��6=   ���#6633996I   5+      �� 5,      $��Bottom=�6   $��Center=�68   .+�5.      �� #��[  6   $��5q�6F   
�������$ 90��6n   $��60 80 60 60q�6�   
 �� Padding$
 15q�6�   ._�5/      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 User=�62   $��80��6?   
������ 
�������$��80��6w   $��Bottom=�6�   $��Center=�6�   52      53      �� 55      $��Center=�6   $��Center=�68   $��	0 50 0 80q�6U   .+�56      �� $��Sign Up��6     $  MaterialDesignHeadline3TextBlock#��[ 6/   
������� �� TextAlignment$ Center=�6}   $��Italic$�6�   $
��Bold"�6�   �� 57      $&�� Enter the user name and password��6    
������� J� Opacity$	 0.8Q�6[   $��
20 5 20 30q�6i   58      59      5:      �� 5<   
   -   5        
�������$��1��5<   $   $ 	0 10 10 0��64   ._�5=      �� $��Center=�6   .+�5@      �� $��10q�6   $��2q�6%    ) %MaterialDesignDarkSeparatorBackground#���  69   $	��300��6   $��50��6�   $ 5��6�   ._�5A      ��  �� Orientation$ 
Horizontal=�6!   .+�5C      �� $��40��6"   $��50��6-   ._�5D        $ Account=�66   $��25��6F   $��25��6Q   $��Center=�6]   $��Center=�6x   5F      �� 5G      $��1q�6"   $��36��5H   "   $	��260��5I   "   $��
5,-2,12,-2q�5J   "   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Username��5K       % !MaterialDesignFloatingHintTextBox#��[ 5N      ��5K   G   �� *
UserName+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�5N      5R      5T      �� 5U      $��2q�6   #���  6-   $	��300��6s   $��50��6   $ 5��6�   $��10q�6�   ._�5V      �� $ 
Horizontal=�6!   .+�5X      �� $��40��6"   $��50��6-   ._�5Y        $
 Lock=�66   $��25��6C   $��25��6N   $��Center=�6Z   $��Center=�6u   5[      G� 5\      -   5         G�Name$ PasswordBox��5^   &   $ Password��5_         
Foreground
 � � � ) %MaterialDesignFloatingHintPasswordBox#��[ 5b      $	��260��5c      $��
5,-2,12,-2q�5d      $��36��5f   !   5j      5l      �� 5s      $ 
Horizontal=�6   $��Center=�66   $
��0 10q�6S   .+�5t      �� $
��Save��6     MaterialDesignRaisedButton#��[ 6N   $	��100��6�   $��
-20 5 10 0q�6�   ��6.   �� *saveCommand+6�   �� 5u      $��Cancel��6   #��[ 6Q   $	��100��6�   $��20 5 0 0q�6�   ��6/   �� *CancelCommand+6�   5w      5y      5z      5}      5~      