   M S B A M L   `   `   `  ����D  @SetConfig, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:SetConfig	SetConfig  5   	       SetConfig.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   
   #localclr-namespace:SetConfig  5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)   ��5
      �� 5   
    �� ImageSource$ assets/bg.jpg��6   .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   � .+�5      �� 
�������$��20q�6%    �� RadiusX$ 20��61    �� RadiusY$ 20��6>    J� Opacity$	 0.8Q�6K   �� 5      -   5         ��Name$ listBox��5      $��30q�6'   65   5      � 5   
   $��1��6   $	��300��6   $	��200��6+    � RowDefinitions 5      �� 5      �� 5      �� 5      �� 5       5       �� 5!      $��80 �6#   �� 5"      .+�5$      �� $��2��6   $��4��6,   $ 20��6=   $ 20��6J   
�������$	 0.8Q�6d   �� 5%      $
��Bold"�6   $
��Left=�6&   $��Center=�6A   .��6\   	Device ID6h   �� 5&      -   5         ��Name$ deviceId��5&      $��1��6(    %  !MaterialDesignFloatingHintTextBox#��[  5'      $��Center=�5(      $��	0 0 10 12q�6   �� 5*      $��1��6   $
��Bold"�6!   $
��Left=�63   $��Center=�6N   .��6i   	IP Server6t   �� 5+      -   5        $ ipServer��5+      $��1��6(   $��1��65   #��[  5,      $��Center=�5-      $��	0 0 10 12q�6   �� 5/      $��2��6   $
��Bold"�6!   $
��Left=�63   $��Center=�6N   .��6i   Port Server6v   �� 50      -   5        $ 
portServer��50      $��2��6*   $��1��68   #��[  51      $��Center=�52      $��	0 0 10 12q�6   �� 54      -   5        $��3��54      $��2��6"   $��Center=�66    $  MaterialDesignFlatAccentBgButton#��[ 55      	 � ToolTip$.	 (MaterialDesignFlatAccentBackgroundButton��56      .��6P   Update58      59      5:      5;      