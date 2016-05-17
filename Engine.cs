﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegreeWork_01
{
    public class Engine
    {
        SkypeControl skypeControl = new SkypeControl();
        BrowserControl browserControl = new BrowserControl();
        SystemControl systemControl = new SystemControl();
        RemindRange remindRange = new RemindRange();

        public void commandsHandler(string command)
        {
            switch(command)
            {
                 // Взаимодействия с системой

                case "выключить компьютер":
                    {
                        systemControl.shutdownSystem();
                        break;
                    }
                case "перезагрузить компьютер":
                    {
                        systemControl.reloadSystem();
                        break;
                    }
                case "сменить язык на русский":
                    {
                        systemControl.changeLanguage("ru");
                        break;
                    }
                case "сделать снимок":
                    {
                        systemControl.makeScreenImage();
                        break;
                    }

                    //Взаимодействие с браузером
                case "открыть новости":
                    {
                        browserControl.openNews();
                        break;
                    }
                case "открыть календарь":
                    {
                        browserControl.openCalendar();
                        break;
                    }
                case "открыть посевной календарь":
                    {
                        browserControl.openMoonCalendar();
                        break;
                    }
                case "открыть погоду":
                    {
                        
                        break;
                    }

                    //Управление напоминаниями

                case "добавить напоминание":
                    {
                        break;
                    }
                case "удалить напоминание":
                    {
                        break;
                    }

                    //Взаимодействия со скайпом
                case "открыть Skype":
                    {
                        skypeControl.startSkype();
                        break;
                    }
                case "Закрыть Skype":
                    {
                        skypeControl.stopSkype();
                        break;
                    }
                case "позвонить":
                    {
                        break;
                    }
                case "видеозвонок":
                    {
                        break;
                    }

            }
        }
    }
}
