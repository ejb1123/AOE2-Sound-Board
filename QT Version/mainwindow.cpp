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
