   M S B A M L   `   `   `  ����G  CItemsEdition, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:ItemsEditionItemsEdition  5          ItemsEdition.Table   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:ItemsEdition     5      U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5         MaterialDesignBody#���   5	      $��Regular"�5
      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper N� 
Background# �  5        MaterialDesignFont N� 
FontFamily# �  5       N� Title$ Table��5      .��5      �  � RowDefinitions 5   
   �� 5      $
��289* �6   �� 5      $
��145* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��dataGrid��5         AutoGenerateColumns$
 True��6#   $��0��6>   5      �� 5   
   -   5          MaterialDesignRaisedButton#��[ 5      3  -MaterialDesignThemes.Wpf.ButtonProgressAssist   Value$ -1Q�5         IsIndicatorVisible$
 True��5       	   IsIndeterminate$
	 True��5!      $��Добавить��5"      $��
10,4,600,3q�5#      $��1��6   6&   �� 5&   
   -   5        #��[ 5'      $ -1Q�5(      $
 True��5)      $
	 True��5*      $��Удалить��5+      $��
600,4,10,3q�5,      $��1��6   6&   �� 50   
   -   5        #��[ 51      $ -1Q�52      $
 True��53      $
	 True��54      $��Изменить��55      $��302,30,302,75q�56      $��1��6   6)   57      58      