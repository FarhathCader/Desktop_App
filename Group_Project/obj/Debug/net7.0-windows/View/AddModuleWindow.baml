   M S B A M L   `   `   `  ����H  DGroup_Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Group_Project.ViewGroup_Project.View  5   	   A%clr-namespace:Group_Project.ViewModelGroup_Project.ViewModel  5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aeHclr-namespace:MaterialDesignThemes.Wpf;assembly=MaterialDesignThemes.WpfMaterialDesignThemes.Wpf 5      (    "Group_Project.View.AddModuleWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   c _MaterialDesignThemes.MahApps, Version=0.3.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5   	   .local clr-namespace:Group_Project.View   5   	   0VM%clr-namespace:Group_Project.ViewModel   5   	   YcontrolsHclr-namespace:MaterialDesignThemes.Wpf;assembly=MaterialDesignThemes.Wpf   5      $��18(�5
   	     � 
ResizeMode$  NoResize=�6    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�6.    � AllowsTransparency$
 True��6A   
������ $	��800��5      $
��1000��6'   .��5      � $��20q�6    J� Effect 5   
   3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 30Q�6      ShadowDepth$ 1Q�6/      Opacity$	 0.4Q�6?    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��2* �6   .+�5   
   �� ���#663399	 �� CornerRadius$	 	10 0 0 10��6)   $
}�True��6B   ._�5       � .+�5"      �� $��	0 180 0 0q�6   $	��Top=�60   .+�5#      �� $��Module Manager��6    $��32(�66   $��Light"�6D   ���#ffffff
 �� TextAlignment$
 Center=�6l   �� 5$      $��to update new modules��6    $��Light"�6=   $��16(�6P   ���#D1F2EB$
 Center=�6s   �� 5%      $	��and��6    $��Light"�6+   $��16(�6>   ���#D1F2EB$
 Center=�6a   $��0 5 0 0q�6x   �� 5&      $��edit modules��6    $��Light"�64   $��16(�6G   ���#D1F2EB$
 Center=�6j   5'      A� 5*      $	��500��6   $	��500��6&   $��Bottom=�63   ���#8c14fc$��50 0 0 -200q�6^    J� Opacity$	 0.6Q�6s   A� 5+      $	��300��6   $	��300��6&   $��Bottom=�63   ���#8c14fc$��-450 0 0 30q�6^   $	 0.3Q�6s   A� 5,      $	��400��6   $	��400��6&   $��Bottom=�63   ���#8c14fc$��-320 0 0 -120q�6^   $	 0.3Q�6u   A� 5-      $	��250��6   $	��250��6&   $��Bottom=�63   ���#8c14fc$��-380 0 0 -120q�6^   A� 5.      $	��400��6   $	��400��6&   $��Bottom=�63   ���#8c14fc$��280 0 0 -70q�6^   $	 0.8Q�6s   �� 50      $��Bottom=�6   $��Center=�68   $��0 0 0 60q�6V   .+�52      ��    IconBorderStyle#��[  6   $��5q�6F   
�������$	 90��6n   $��60q�6�    �� Padding$ 15q�6�   ._�53      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$	 Abc=�62   $	��100��6>   
������ 
�������$	��100��6w   $��Bottom=�6�   $��Center=�6�   56      57      59      5:      � 5>   
   $��1��6   
������� � RowDefinitions 5?      �� 5@      $
��auto �6    �� 5A      $
��auto �6    .+�5E      �� $
��0 10q�6   $��Center=�6'   .+�5H      �� $��Right=�6   $	��Top=�67   $��10q�6o     circleButton2#��[ 6|    � ToolTip$
 Exit��6�   $��20��6�   $��20��6�   ��6O   �� *exitCommand+��5I        5J      $ Close=�6,   $��15��69   $��15��6E    J� RenderTransformOrigin$ 0.98,-10.733&�6Q   5M      �� 5P      $��5q�6   $��2q�6$    ) %MaterialDesignDarkSeparatorBackground#���  68   $	��300��6~   $��50��6�   $	 5��6�   ._�5R      �� $��0q�6   $��50��5S   "   $	��260��5T   "   $��
5,-2,12,-2q�5U   "   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Module Code��5V       % !MaterialDesignFloatingHintTextBox#��[ 5Z      ��5X      �� *
ModuleCode+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�5Z      5\      �� 5]      $��5q�6   $��2q�6$   #���  68   $	��300��6~   $��50��6�   $	 5��6�   ._�5_      �� $��1q�6   $��50��5`   "   $	��260��5a   "   $��
5,-2,12,-2q�5b   "   $ Module Name��5d      #��[ 5e      ��5c   "   �� *
ModuleName+$ PropertyChanged=�$ TwoWay=�5e      5f      �� 5g      $��5q�6   $��2q�6$   #���  68   $	��300��6~   $��50��6�   $	 5��6�   ._�5i      �� $��1q�6   $��50��5j   "   $	��260��5k   "   $��
5,-2,12,-2q�5l   "   $ Credits��5m      #��[ 5o      ��5n   #   �� *	Credits+$ PropertyChanged=�$ TwoWay=�5o      5q      �� 5s       �� Orientation$ 
Horizontal=�6   $��5q�67   $��Center=�6B   .+�5t      ��   MaterialDesignRaisedButton#��[ 6   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 5��6Q   $
��Save��6~   ���#ffffff$��18(�6�   $��45��6�   $	��120��6�   $��
0 10 10 10q�6�   ��6�   �� *saveCommand+5u      5w      �� 5x      $ 10q�6   
���   �$��2q�5z      $	 10��5{      $��	25 0 25 0q�5|      $��1��5}      ._�5�      �� $	��400��5�        MaterialDesignListView#��[ 5�        MaterialDesignPaper#���  5�       �� SelectionMode$ Single=�5�      ��5�      �� *
ModuleList+ �� View 5�      �� 5�      .P�5�      �� $��Module Code��6-    �� DisplayMemberBinding 6C   �� *
ModuleCode+$ PropertyChanged=�$ TwoWay=��� 5�      $��Module Name��6-    6B   �� *
ModuleName+$ PropertyChanged=�$ TwoWay=��� 5�      $��Credits��6-    6>   �� *	Credits+$ PropertyChanged=�$ TwoWay=��� 5�       �� CellTemplate 5�   "   �� 5�   &   .R�5�   *   �� $ 
Horizontal=�65   .+�5�   .   �� #��[ 65   $
��10 5q�6\   $��30��6�   $��30��6  ��6j   �� *DataContext.editModuleCommand+ �� RelativeSource ��  �� AncestorType" ����6�   �� ��5�   2     5�   6   $
 Edit=�6H   $��15��6T   $��15��6`   5�   /   �� 5�   .   #��[ 65   $
��10 5q�6\   $��30��6�   $��30��6  ��6j   �� *!DataContext.removeModuleCommand+ �� " ����6�   �� ��5�   2     5�   6   $ Delete=�6H   $��15��6V   $��15��6b   5�   /   5�   +   5�   '   5�      5�      5�      5�      5�      5�      5�      