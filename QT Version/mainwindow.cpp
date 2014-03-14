#include "mainwindow.h"
#include "ui_mainwindow.h"
#include <QSound>
#include <QString>
MainWindow::MainWindow(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::MainWindow)
{
    ui->setupUi(this);
}

MainWindow::~MainWindow()
{
    delete ui;
}
void Player(QString File)
{
    QSound::play(":/sounds/" + File + ".wav");
}



void MainWindow::on_pushButton_clicked()
{   Player("01");
}

void MainWindow::on_pushButton_2_clicked()
{
    Player("02");
}

void MainWindow::on_pushButton_3_clicked()
{
    Player("03");
}

void MainWindow::on_pushButton_4_clicked()
{
    Player("04");
}

void MainWindow::on_pushButton_5_clicked()
{
   Player("05");
}

void MainWindow::on_pushButton_6_clicked()
{
    Player("06");
}

void MainWindow::on_pushButton_7_clicked()
{
    Player("07");
}

void MainWindow::on_pushButton_8_clicked()
{
    Player("08");
}

void MainWindow::on_pushButton_9_clicked()
{
    Player("09");
}

void MainWindow::on_pushButton_10_clicked()
{
    Player("10");
}

void MainWindow::on_pushButton_11_clicked()
{
    Player("11");
}

void MainWindow::on_pushButton_12_clicked()
{
    Player("12");
}

void MainWindow::on_pushButton_13_clicked()
{
    Player("13");
}

void MainWindow::on_pushButton_14_clicked()
{
    Player("14");
}

void MainWindow::on_pushButton_15_clicked()
{
    Player("15");
}

void MainWindow::on_pushButton_16_clicked()
{
    Player("16");
}

void MainWindow::on_pushButton_17_clicked()
{
    Player("17");
}

void MainWindow::on_pushButton_18_clicked()
{
    Player("18");
}

void MainWindow::on_pushButton_19_clicked()
{
    Player("19");
}

void MainWindow::on_pushButton_20_clicked()
{
    Player("20");
}

void MainWindow::on_pushButton_21_clicked()
{
    Player("21");
}

void MainWindow::on_pushButton_22_clicked()
{
    Player("22");
}

void MainWindow::on_pushButton_23_clicked()
{
    Player("23");
}

void MainWindow::on_pushButton_24_clicked()
{
    Player("24");
}

void MainWindow::on_pushButton_25_clicked()
{
    Player("25");
}

void MainWindow::on_pushButton_26_clicked()
{
    Player("26");
}

void MainWindow::on_pushButton_27_clicked()
{
    Player("27");
}

void MainWindow::on_pushButton_28_clicked()
{
    Player("28");
}

void MainWindow::on_pushButton_29_clicked()
{
    Player("29");
}

void MainWindow::on_pushButton_30_clicked()
{
 Player("30");
}
