   M S B A M L   `   `   `  ����H  DGroup_Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Group_Project.ViewGroup_Project.View  5   	   A%clr-namespace:Group_Project.ViewModelGroup_Project.ViewModel  5   	   )    #Group_Project.View.EditCourseWindow   5   
   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   c _MaterialDesignThemes.MahApps, Version=0.3.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a_ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5   	   .local clr-namespace:Group_Project.View   5   	   0VM%clr-namespace:Group_Project.ViewModel   5   	   $��18(�5
   	     � 
ResizeMode$  NoResize=�6    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�6.    � AllowsTransparency$
 True��6A   
������ $	��645��5      $	��875��6'    � DataContext 5      0   *Group_Project.ViewModel.EditCourseWindowVM  5   
   .��5      � $��20q�6    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 30Q�6#      ShadowDepth$ 1Q�63      Opacity$	 0.4Q�6C   	 � ColumnDefinitions	 5      �� 5      $��* �6#   �� 5      $��1.22* �6#   .+�5   
   �� ���#663399
 �� CornerRadius$
 	10 0 0 10��6)   $
}�True��6B    J� Clip 5       �� 5!       �� RadiusX$ 10Q�6(    �� RadiusY$ 10Q�65    �� Rect$ 0,0,400,605�6B   ._�5$      � .+�5&      �� $��	0 120 0 0q�6!   $	��Top=�64   .+�5'      �� $��Course Manager��6$   $��46(�6:   $��Light"�6H   ���#ffffff �� TextAlignment$ Center=�6p   �� 5(      $��to update new courses��6    $��Light"�6=   $��16(�6P   ���#D1F2EB$ Center=�6s   �� 5)      $	��and��6    $��Light"�6+   $��16(�6>   ���#D1F2EB$ Center=�6a   $��0 5 0 0q�6x   �� 5*      $��Edit Courses��6    $��Light"�64   $��16(�6G   ���#D1F2EB$ Center=�6j   5+      A� 5.      $	��500��6   $	��500��6*   $��Bottom=�67   ���#8c14fc$��50 0 0 -200q�6b    J� Opacity$	 0.6Q�6w   A� 5/      $	��300��6   $	��300��6*   $��Bottom=�67   ���#8c14fc$��-450 0 0 30q�6b   $	 0.3Q�6w   A� 50      $	��400��6   $	��400��6*   $��Bottom=�67   ���#8c14fc$��-320 0 0 -120q�6b   $	 0.3Q�6y   A� 51      $	��250��6   $	��250��6*   $��Bottom=�67   ���#8c14fc$��-380 0 0 -120q�6b   A� 52      $	��400��6   $	��400��6*   $��Bottom=�67   ���#8c14fc$��280 0 0 -70q�6b   $	 0.8Q�6w   �� 54      $��Bottom=�6   $��Center=�68   .+�56      ��    IconBorderStyle#��[  6   $��5q�6F   
�������$
 90��6n   $��60q�6�    �� Padding$ 15q�6�   ._�57      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Certificate=�62   $	��100��6F   
������ 
�������$	��100��6   $��Bottom=�6�   $��Center=�6�   5:      5;      5=      5>      �� 5A      $��1��6   ���#ffffff$
 	0 10 10 0��6:   ._�5B      � .+�5G      �� $
��0 50q�6   $��Center=�6+   .+�5L      �� $��20q�6   $��2q�6)    ) %MaterialDesignDarkSeparatorBackground#���  6=   $	��300��6�   $��60��6�   $
 5��6�   ._�5N      �� $��1q�6"   $��60��5O   "   $	��260��5P   "   $��
5,-2,12,-2q�5Q   "   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Course Name��5R         
Foreground
 � � � % !MaterialDesignFloatingHintTextBox#��[ 5W      ��5S      �� *
CourseName+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�5W      5Y      �� 5Z      $��20q�6   $��2q�6)   #���  6=   $	��300��6�   $��60��6�   $
 5��6�   ._�5\      �� $��1q�6"   $��60��5]   "   $	��260��5^   "   $��
5,-2,12,-2q�5_   "   $ Course Code��5`      
 � � �#��[ 5e      ��5a   "   �� *Code+$ PropertyChanged=�$ TwoWay=�5e      5k      �� 5m       �� Orientation$ 
Horizontal=�6!   $��20q�6;   $��Center=�6G   .+�5n      ��   MaterialDesignRaisedButton#��[ 6!   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 5��6U   $
��Save��6�   ���#ffffff$��18(�6�   $��45��6�   $	��120��6�   $��
0 10 10 10q�6�   ��6�   �� *saveCommand+6�   �� 5o      $��Cancel��6!   $ 5��6T   $��16(�6�   $��45��6�   $	��120��6�   $��
10 10 0 10q�6�   ��62   �� *CancelCommand+6�   5p      5r      5t      5u      5w      5x      