   M S B A M L   `   `   `  ����H  DGroup_Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Group_Project.ViewGroup_Project.View  5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aeHclr-namespace:MaterialDesignThemes.Wpf;assembly=MaterialDesignThemes.WpfMaterialDesignThemes.Wpf 5   	   -    'Group_Project.View.GPACalculationWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Group_Project.View     5   	   ]controlsHclr-namespace:MaterialDesignThemes.Wpf;assembly=MaterialDesignThemes.Wpf     5   	   c _MaterialDesignThemes.MahApps, Version=0.3.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5	   	     � Title$  GPACalculationWindow��5   	   $	��750��6&   $	��500��63    � WindowStyle$
 None=�5       � AllowsTransparency$
 True��5   	    � WindowStartupLocation$ CenterScreen=�5   	   
������ .��5      � $��20q�6    J� Effect 5   
   3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 30Q�6      ShadowDepth$ 1Q�6/      Opacity$	 0.4Q�6?   .+�5   
   �� ���#663399 �� CornerRadius$ 10��6)   $
}�True��6;   ._�5      � .+�5      �� $��Right=�6   $	��Top=�67   $��10q�6o      circleButton3#��[  6|   	 � ToolTip$
	 Exit��6�   $��20��6�   $��20��6�   ��6O   �� *exitCommand+��5      '  !MaterialDesignThemes.Wpf.PackIcon  5      
   Kind$
 Close=�6,   $��15��69   $��15��6E   
������� J� RenderTransformOrigin$ 0.98,-10.733&�6c   5"      A� 5%      $	��420��6   $��Bottom=�6'   ���#8c14fc$��225,0,-165,-211q�6R    J� Opacity$	 0.4Q�6k   A� 5&      $	��400��6   $	��400��6&   $��Bottom=�63   ���#8c14fc$��-233,0,283,-191q�6^   $	 0.3Q�6w   A� 5(      $	��420��6   $	��Top=�6'   ���#8c14fc$��30,515,30,0q�6O   $	 0.4Q�6d   A� 5)      $	��420��6   $	��Top=�6'   ���#8c14fc$��-112,470,172,0q�6O   $	 0.2Q�6g   A� 5*      $	��420��6   $	��Top=�6'   ���#8c14fc$��10,431,50,0q�6O   $	 0.4Q�6d   A� 5+      $	��420��6   $��Bottom=�6'   ���#8c14fc$��167,0,-107,-191q�6R   $	 0.4Q�6k   A� 5,      $	��420��6   $��Bottom=�6'   ���#8c14fc$��-233,0,293,-172q�6R   $	 0.4Q�6k   � 5/       � RowDefinitions 50      �� 51      $
��auto �6(   �� 52      $
��auto �6(   �� 53      $
��auto �6(   .+�56      �� $��	0 40 0 10q�6!   .+�57      ��  �� Orientation$ 
Horizontal=�6%   $
��80 0q�6>   .+�58      �� $��Student Name :��6(   
�������$��16(�6Q   $��10q�6_   �� 59      
�������$��16(�6X   $��20 10q�6f   ��6(   �� *StudentName+6f   5:      �� 5;      $ 
Horizontal=�6%   $
��80 0q�6>   .+�5<      �� $��Enrolled Course :��6(   
�������$��16(�6T   $��10q�6b   �� 5=      
�������$��16(�6W   $��10q�6e   ��6(   �� *
CourseName+6e   5>      5?      �� 5A      $��1��6   
�������$��20q�6=   $��2q�6I   $ 10��6]   
���   �._�5B      �� $	��350��6I   ��6#   �� *CourseModules+ �� View 5C      �� 5D   "   .P�5E   &   �� $��Module Name��65    �� CellTemplate 5F   *   �� 5G   .   .R�5H   2   �� ._�5K   6   �� ��6@   �� *
ModuleName+5M   3   5N   /   5P   '   �� 5Q   &   $��Grade��65    5R   *   �� 5S   .   .R�5T   2   �� ._�5V   6   �� ��6?   �� *Grades+ �� SelectedItem 6^   �� *Result+5X   7   5Z   3   5[   /   5]   '   5_   #   5a      5b      �� 5c      $��2��6   $��Calculate GPA��6*   $	��160��6C   $��20q�6O   ��6[   �� *calculateGPACommand+5g      �� 5m      $��Bottom=�6   $��Center=�68   $��	0 0 0 -40q�6V   .+�5o      ��   IconBorderStyle#��[ 6   $��5q�6F   
�������$ 90��6n   $��60q�6�    �� Padding$ 15q�6�   ._�5p        $	
 Abc=�62   $��60��6>   
������ 
�������$��60��6v   $��Bottom=�6�   $��Center=�6�   5s      5t      5v      5w      5z      5{      