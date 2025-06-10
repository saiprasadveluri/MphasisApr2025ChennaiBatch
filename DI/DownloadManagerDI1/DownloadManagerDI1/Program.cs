// See https://aka.ms/new-console-template for more information
using DownloadManagerDI1;
using System.Reflection;

Console.WriteLine("Hello, World!");
IMessageSender sender = new EmailSender();

DownloadManager dm = new DownloadManager();
dm.messageSender = sender;

//dm.DoAction("http://localhost:4200/filepath");
//dm.DoAction_V2("http://localhost:4200/filepath");//With SRP.
dm.DoAction_V3("http://localhost:4200/filepath");
/*
NameServiceLocator SrvLocator =NameServiceLocator.Instance;

SrvLocator.RegisterService("EMAIL", new EmailSender());
SrvLocator.RegisterService("SMS", new SMSSender());

object messageSender = NameServiceLocator.Instance.GetService("SMS");
IMessageSender msgSender = messageSender as IMessageSender;
DownloadManager dm = new DownloadManager();
dm.messageSender = msgSender;
dm.DoAction_V3("path");*/