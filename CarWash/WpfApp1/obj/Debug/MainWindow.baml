   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   !localclr-namespace:WpfApp1  5   	     � Title$  
MainWindow��5	   	   $	��650��6   $	��800��6)   .��5
      � 
�������.+�5   
   �� $��Images\Logo.jpg��6   $��10,10,682,505q�6)   �� 5   
   -   5        $��	BamperImg��5   +   $��Images\Bamper.jpg��6   $��150,10,40,505q�6<    �� BitmapScalingMode$ HighQuality=�6S   $
��Fill=�6�   � 5   
   $��0,132,25,99q�6   
�������.+�5      �� -   5        $��WashOptionsLv��5      $��	0,0,467,0q�6,   �� 5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Reserve a place��6    %  !MaterialDesignFloatingHintTextBox#��[  6G   $��335,22,25,304q�6�   �� 5      -   5        $��InsertDataTime��5      $��323,99,25,82q�6-   �� 5      -   5        $��CurrentPrice��5      $��323,315,280,25q�6,   
�������$��38(�6V   �� 5      -   5        $��
ConfirmBtn��5        MaterialDesignRaisedButton#��[ 6'    � ToolTip$/ )Resource name: MaterialDesignRaisedButton��6[   $��560,315,43,25q�6�   $
��Auto��6�   $��Confirm a reserve��6�   5      �� 5   
   -   5        $��CurrentSale��5      $��36,545,604,21q�6'   
�������$��40(�6V   �� 5   
   -   5        $��SaleCb��5      $��269,545,25,21q�6!   $��55��68   5      5      