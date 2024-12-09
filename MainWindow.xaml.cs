<Window x:Class="WpfApp2.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:WpfApp2"
        mc:Ignorable="d"
        Title="Калькулятор" Height="450" Width="300">
    <Grid>
        <!-- Область отображения результата -->
        <Grid.RowDefinitions>
            <RowDefinition Height="Auto"/>
            
            <RowDefinition Height="*"/>
           
        </Grid.RowDefinitions>
        <TextBox Name="txtDisplay" Grid.Row="0" Margin="10" FontSize="24" 
                 TextAlignment="Right" IsReadOnly="True" Grid.ColumnSpan="5"/>
    

      
        <Grid Grid.Row="1" Margin="10" ShowGridLines="False">
           
            <Grid.RowDefinitions>
                <RowDefinition Height="*"/>
                <RowDefinition Height="*"/>
                <RowDefinition Height="*"/>
                <RowDefinition Height="*"/>
                <RowDefinition Height="*"/>
            </Grid.RowDefinitions>
            <Grid.ColumnDefinitions>
                <ColumnDefinition Width="*"/>
                <ColumnDefinition Width="*"/>
                <ColumnDefinition Width="*"/>
                <ColumnDefinition Width="*"/>
                <ColumnDefinition Width="*"/>
            </Grid.ColumnDefinitions>

           
            <Button Name="btn7" Content="7" Grid.Row="0" Grid.Column="0" Click="btnNumber_Click" Tag="7"/>
            
            <Button Name="btn8" Content="8" Grid.Row="0" Grid.Column="1" Click="btnNumber_Click" Tag="8"/>
            <Button Name="btn9" Content="9" Grid.Row="0" Grid.Column="2" Click="btnNumber_Click" Tag="9"/>
            <Button Name="btn4" Content="4" Grid.Row="1" Grid.Column="0" Click="btnNumber_Click" Tag="4"/>
            <Button Name="btn5" Content="5" Grid.Row="1" Grid.Column="1" Click="btnNumber_Click" Tag="5"/>
            <Button Name="btn6" Content="6" Grid.Row="1" Grid.Column="2" Click="btnNumber_Click" Tag="6"/>
            <Button Name="btn1" Content="1" Grid.Row="2" Grid.Column="0" Click="btnNumber_Click" Tag="1"/>
            <Button Name="btn2" Content="2" Grid.Row="2" Grid.Column="1" Click="btnNumber_Click" Tag="2"/>
            <Button Name="btn3" Content="3" Grid.Row="2" Grid.Column="2" Click="btnNumber_Click" Tag="3"/>
            <Button Name="btn0" Content="0" Grid.Row="3" Grid.Column="1" Click="btnNumber_Click" Tag="0"/>
            <Button Name="btnDecemal" Content="." Grid.Row="3" Grid.Column="2" Click="btnDecemal_Click"/>


            <Button Name="btnClear" Content="C" Grid.Row="3" Grid.Column="0" Click="btnClear_Click" ToolTip="Очистить"/>
            <Button Name="btnAdd" Content="+" Grid.Row="0" Grid.Column="3" Click="btnOperation_Click" Tag="+" ToolTip="Сложение: a+b"/>
            <Button Name="btnRemove" Content="-" Grid.Row="1" Grid.Column="3" Click="btnOperation_Click" Tag="-" ToolTip="Вычитание:a-b"/>
            <Button Name="btnMuti" Content="x" Grid.Row="2" Grid.Column="3" Click="btnOperation_Click" Tag="*" ToolTip="Умножение:a*b"/>
            <Button Name="btnDivis" Content="/" Grid.Row="3" Grid.Column="3" Click="btnOperation_Click" Tag="/" ToolTip="Деление:a/b"/>
            <Button Name="btnEquals" Content="=" Grid.Row="0" Grid.Column="4" Grid.RowSpan="4" Click="btnEquals_Click" ToolTip="Равно: =,результат"/>


        </Grid>
    </Grid>
</Window>
