   M S B A M L   `   `   `  ����H  DGroup_Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Group_Project.ViewGroup_Project.View  5   	   A%clr-namespace:Group_Project.ViewModelGroup_Project.ViewModel  5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aeHclr-namespace:MaterialDesignThemes.Wpf;assembly=MaterialDesignThemes.WpfMaterialDesignThemes.Wpf 5      (    "Group_Project.View.AdminCourseMenu   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   c _MaterialDesignThemes.MahApps, Version=0.3.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5   	   .local clr-namespace:Group_Project.View   5   	   0VM%clr-namespace:Group_Project.ViewModel   5   	   YcontrolsHclr-namespace:MaterialDesignThemes.Wpf;assembly=MaterialDesignThemes.Wpf   5      $��18(�5
   	     � 
ResizeMode$  NoResize=�6    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�6.    � AllowsTransparency$
 True��6A   
������ $	��800��5      $
��1100��6'   .��5      � $��20q�6    J� Effect 5   
   3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 30Q�6      ShadowDepth$ 1Q�6/      Opacity$	 0.4Q�6?    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��2* �6   .+�5   
   �� ���#663399	 �� CornerRadius$	 	10 0 0 10��6)   $
}�True��6B   ._�5       � .+�5"      �� $��	0 240 0 0q�6   $	��Top=�60   .+�5#      �� $��Course Manager��6    $��32(�66   $��Light"�6D   ���#ffffff
 �� TextAlignment$
 Center=�6l   �� 5$      $��to update new modules��6    $��Light"�6=   $��16(�6P   ���#D1F2EB$
 Center=�6s   �� 5%      $	��and��6    $��Light"�6+   $��16(�6>   ���#D1F2EB$
 Center=�6a   $��0 5 0 0q�6x   �� 5&      $��edit modules��6    $��Light"�64   $��16(�6G   ���#D1F2EB$
 Center=�6j   5'      A� 5*      $	��500��6   $	��500��6&   $��Bottom=�63   ���#8c14fc$��50 0 0 -200q�6^    J� Opacity$	 0.6Q�6s   A� 5+      $	��300��6   $	��300��6&   $��Bottom=�63   ���#8c14fc$��-450 0 0 30q�6^   $	 0.3Q�6s   A� 5,      $	��400��6   $	��400��6&   $��Bottom=�63   ���#8c14fc$��-320 0 0 -120q�6^   $	 0.3Q�6u   A� 5-      $	��250��6   $	��250��6&   $��Bottom=�63   ���#8c14fc$��-380 0 0 -120q�6^   A� 5.      $	��400��6   $	��400��6&   $��Bottom=�63   ���#8c14fc$��280 0 0 -70q�6^   $	 0.8Q�6s   �� 50      $��Bottom=�6   $��Center=�68   $��0 0 0 80q�6V   .+�52      ��    IconBorderStyle#��[  6   $��5q�6F   
�������$	 90��6n   $��60q�6�    �� Padding$ 15q�6�   ._�53      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Certificate=�62   $	��100��6F   
������ 
�������$	��100��6   $��Bottom=�6�   $��Center=�6�   56      57      59      5:      �� 5=   
   $��1��6   $	 	0 10 10 0��6!   
�������._�5>      � $��1��6    � RowDefinitions 5?      �� 5@      $
��auto �6$   �� 5A      $
��auto �6$   .+�5E      �� $
��0 20q�6   $��Center=�6+   .+�5H      �� $��Right=�6   $	��Top=�6;   $��10q�6s     circleButton2#��[ 6�    � ToolTip$
 Exit��6�   $��20��6�   $��20��6�   ��6S   �� *exitCommand+��5I        5J      $ Close=�60   $��15��6=   $��15��6I    J� RenderTransformOrigin$ 0.98,-10.733&�6U   5M      �� 5O      $��5q�6   $��2q�6(    ) %MaterialDesignDarkSeparatorBackground#���  6<   $	��300��6�   $��50��6�   $	 5��6�   ._�5Q      �� $��0q�6"   $��50��5R   "   $	��260��5S   "   $��
5,-2,12,-2q�5T   "   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Course Name��5U       % !MaterialDesignFloatingHintTextBox#��[ 5Y      ��5W      �� *
CourseName+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�5Y      5[      �� 5\      $��5q�6   $��2q�6(   #���  6<   $	��300��6�   $��50��6�   $	 5��6�   ._�5^      �� $��1q�6"   $��50��5_   "   $	��260��5`   "   $��
5,-2,12,-2q�5a   "   $
 Code��5c      #��[ 5d      ��5b   "   �� *Code+$ PropertyChanged=�$ TwoWay=�5d      5e      �� 5h       �� Orientation$ 
Horizontal=�6!   $��5q�6;   $��Center=�6F   .+�5i      ��   MaterialDesignRaisedButton#��[ 6!   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 5��6U   $
��Save��6�   ���#ffffff$��18(�6�   $��45��6�   $	��120��6�   $��
0 10 10 10q�6�   ��6�   �� *saveCommand+5j      5l      �� 5m      $ 10q�6   
���   �$��2q�5o      $	 10��5p      $��	25 0 25 0q�5q      $��1��5r      ._�5v      �� $	��440��5x        MaterialDesignListView#��[ 5y        MaterialDesignPaper#���  5z       �� SelectionMode$ Single=�5{      ��5w      �� *
CourseList+ �� View 5~      �� 5      .P�5�   "   �� $��Course Name��61    �� DisplayMemberBinding 6G   �� *
CourseName+$ PropertyChanged=�$ TwoWay=��� 5�   "   $
��Code��61    6?   �� *Code+$ PropertyChanged=�$ TwoWay=��� 5�   "    �� CellTemplate 5�   &   �� 5�   *   .R�5�   .   �� $ 
Horizontal=�69   .+�5�   2   �� #��[ 69   $
��10 5q�6`   $��30��6�   $��30��6
  ��6n   �� *DataContext.editCourseCommand+ �� RelativeSource ��  �� AncestorType" ����6�   �� ��5�   6     5�   :   $
 Edit=�6L   $��15��6X   $��15��6d   5�   3   �� 5�   2   #��[ 69   $
��10 5q�6`   $��30��6   $��30��6  ��6n   �� *!DataContext.removeCourseCommand+ �� " ����6�   �� ��5�   6     5�   :   $ Delete=�6L   $��15��6Z   $��15��6f   5�   3   �� 5�   2   #��[ 6;   $��Add Modules��6o   ���#ffffff$��5q�6+  ��6�   �� *DataContext.addModulesCommand+ �� " ����6�   �� 6+  5�   /   5�   +   5�   #   5�      5�      5�      5�      5�      5�      5�      