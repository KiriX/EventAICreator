﻿using System.Windows.Forms;
using System.Drawing;

namespace EventAI
{
    public class Inscription
    {
        public static void ShowActionParametr(ComboBox combobox, ComboBox cb1, ComboBox cb2, ComboBox cb3, Label l1, Label l2, Label l3)
        {
            ((GroupBox)combobox.Parent).Reset();
            
            switch ((ActionType)combobox.SelectedValue.ToUInt32())
            {
                case ActionType.ТЕКСТ:
                    l1.Text = "ID текста 1";
                    //new ButtonHandler(cb1, BType.TEXT);
                    l2.Text = "ID текста 2";
                    l3.Text = "ID текста 3";
                    break;
                case ActionType.УСТАНОВИТЬ_ФРАКЦИЮ:
                    l1.Text = "ID фракции";
                    cb1.SetDbcData(DBC.Faction);
                    break;
                case ActionType.ИЗМЕНИТЬ_МОДЕЛЬ_СУЩЕСТВА:
                    l1.Text = "ID существа";
                    new ButtonHandler(cb1, BType.CREATURE);
                    l2.Text = "ID модели";
                    break;
                case ActionType.ЗВУК:
                    l1.Text = "ID звука";
                    break;
                case ActionType.ЭМОЦИЯ:
                    l1.Text = "ID эмоции";
                    cb1.SetDbcData(DBC.Emotes);
                    break;
                case ActionType.ЧТЕНИЕ_ЗАКЛИНАНИЯ:
                    l1.Text = "ID спелла";
                    new ButtonHandler(cb1, BType.SPELL);
                    l2.Text = "Цель";
                    cb2.SetEnumValues<CastTarget>();
                    l3.Text = "Флаг каста";
                    new ButtonHandler(cb3, typeof(CastFlags));
                    break;
                case ActionType.ПРИЗЫВ:
                    l1.Text = "ID существа";
                    new ButtonHandler(cb1, BType.CREATURE);
                    l2.Text = "Цель";
                    l3.Text = "Продолжительность (мс)";
                    cb2.SetEnumValues<CastTarget>();
                    break;
                case ActionType.ИЗМЕНИТЬ_УГРОЗУ:
                    l1.Text = "Угроза %";
                    l2.Text = "Цель";
                    cb2.SetEnumValues<CastTarget>();
                    break;
                case ActionType.ИЗМЕНИТЬ_УГРОЗУ_ДЛЯ_ВСЕХ:
                    l1.Text = "Угроза %";
                    break;
                case ActionType.ВЫПОЛНИТЬ_УСЛОВИЕ_КВЕСТА:
                    l1.Text = "ID квеста";
                    new ButtonHandler(cb1, BType.QUEST);
                    l2.Text = "Цель";
                    cb2.SetEnumValues<CastTarget>();
                    break;
                case ActionType.ЗАСТАВИТЬ_ЧИТАТЬ_ЗАКЛИНАНИЕ:
                    l1.Text = "ID существа";
                    new ButtonHandler(cb1, BType.CREATURE);
                    l2.Text = "ID спелла";
                    new ButtonHandler(cb2, BType.SPELL);
                    l3.Text = "Цель";
                    cb3.SetEnumValues<CastTarget>();
                    break;
                case ActionType.ИЗМЕНИТЬ_UNIT_FIELD:
                    l1.Text = "Номер поля Data";
                    cb1.SetEnumValues<EUnitFields>("", "UNIT_FIELD_");
                    l2.Text = "Значение";
                    l3.Text = "Цель";
                    cb3.SetEnumValues<CastTarget>();
                    break;
                case ActionType.ИЗМЕНИТЬ_UNIT_FLAG:
                    l1.Text = "Флаг существа";
                    new ButtonHandler(cb1, typeof(UnitFlags));
                    l2.Text = "Цель";
                    cb2.SetEnumValues<CastTarget>();
                    break;
                case ActionType.УБРАТЬ_UNIT_FLAG:
                    l1.Text = "Флаг существа";
                    new ButtonHandler(cb1, typeof(UnitFlags));
                    l2.Text = "Цель";
                    cb2.SetEnumValues<CastTarget>();
                    break;
                case ActionType.АВТО_АТАКА_БЛИЖНЕГО_БОЯ:
                    l1.Text = "Разрешить атаку в ближнем бою";
                    cb1.SetEnumValues<YesNO>();
                    break;
                case ActionType.ДВИЖЕНИЕ_В_БОЮ:
                    l1.Text = "Разрешить движение в бою";
                    l2.Text = "Остановить, стартовать режим боя";
                    cb1.SetEnumValues<YesNO>();
                    cb2.SetEnumValues<YesNO>();
                    break;
                case ActionType.УСТАНОВИТЬ_ФАЗУ:
                    l1.Text = "Фаза";
                    new ButtonHandler(cb1, typeof(Phase));
                     break;
                case ActionType.ПОВЫСИТЬ_ФАЗУ:
                    l1.Text = "Значение";
                    break;
                case ActionType.ЗАВЕРШИТЬ_КВЕСТ_ДЛЯ_ГРУППЫ:
                    l1.Text = "ID квеста";
                    new ButtonHandler(cb1, BType.QUEST);
                    break;
                case ActionType.ЗАСЧИТАТЬ_ЧТЕНИЕ_ЗАКЛИНАНИЯ_ДЛЯ_ГРУППЫ:
                    l1.Text = "ID квеста";
                    new ButtonHandler(cb1, BType.QUEST);
                    l2.Text = "ID спелла";
                    new ButtonHandler(cb2, BType.SPELL);
                    break;
                case ActionType.УБРАТЬ_С_ЦЕЛИ_АУРУ:
                    l1.Text = "Цель";
                    cb1.SetEnumValues<CastTarget>();
                    l2.Text = "ID спелла";
                    new ButtonHandler(cb2, BType.SPELL);
                    break;
                case ActionType.УДАЛИТСЯ_ОТ_ЦЕЛИ:
                    l1.Text = "Дистанция";
                    l2.Text = "Под углом";
                    break;
                case ActionType.СЛУЧАЙНАЯ_ФРАЗА:
                    l1.Text = "ID фазы 1";
                    new ButtonHandler(cb1, typeof(Phase));
                    l2.Text = "ID фазы 2";
                    new ButtonHandler(cb2, typeof(Phase));
                    l3.Text = "ID фазы 3";
                    new ButtonHandler(cb3, typeof(Phase));
                    break;
                case ActionType.СЛУЧАЙНАЯ_ФАЗА_С_ПАРАМЕТРОМ:
                    l1.Text = "Минимальный номер фазы";
                    new ButtonHandler(cb1, typeof(Phase));
                    l2.Text = "Максимальный номер фазы";
                    new ButtonHandler(cb2, typeof(Phase));
                    break;
                case ActionType.ПРИЗЫВ_В_ОПРЕДЕЛЕННУЮ_ТОЧКУ:
                    l1.Text = "ID существа";
                    new ButtonHandler(cb1, BType.CREATURE);
                    l2.Text = "Цель";
                    cb2.SetEnumValues<CastTarget>();
                    l3.Text = "ID из creature_ai_summons";
                    break;
                case ActionType.ЗАСЧИТАТЬ_УБИЙСТВО_СУЩЕСТВА:
                    l1.Text = "ID существа";
                    new ButtonHandler(cb1, BType.CREATURE);
                    l2.Text = "Цель";
                    cb2.SetEnumValues<CastTarget>();
                    break;
                case ActionType.SET_INST_DATA:
                    l1.Text = "Поле";
                    l2.Text = "Значение";
                    cb2.SetEnumValues<InstantData>();
                    break;
                case ActionType.SET_INST_DATA64:
                    l1.Text = "Поле";
                    l2.Text = "Цель";
                    cb2.SetEnumValues<CastTarget>();
                    break;
                case ActionType.ИЗМЕНИТЬ_ПАРАМЕТРЫ_СУЩЕСТВА:
                    l1.Text = "Существо";
                    new ButtonHandler(cb1, BType.CREATURE);
                    l2.Text = "Команда:";
                    cb2.SetEnumValues<Team>();
                    break;
                case ActionType.ОБРАТИТЬСЯ_ЗА_ПОМОЩЬЮ:
                    l1.Text = "В радиусе:";
                    break;
                case ActionType.ВИЗУАЛИЗАЦИЯ_ДЕЙСТВИЯ_С_ОРУЖИЕМ:
                    l1.Text = "Действие";
                    cb1.SetEnumValues<SheathState>();
                     break;
                case ActionType.ПРИНУДИТЕЛЬНО_ДЕСПАВНИТЬ:
                     l1.Text = "Задержка (мс)";
                    break;
                case ActionType.НЕВОЗМОЖНОСТЬ_АТАКОВАТЬ:
                    l1.Text = "Тип значения";
                    l2.Text = "При значении жизни";
                    cb1.SetEnumValues<ValueType>();
                    break;
                case ActionType.ОСЕДЛАТЬ_МАУНТА_ПО_ENTRY_ИЛИ_ИД_МОДЕЛИ:
                    l1.Text = "Существо";
                    l2.Text = "Модель";
                    new ButtonHandler(cb1, BType.CREATURE);
                    break;
            }

            cb1.Visible = l1.Text != string.Empty;
            cb2.Visible = l2.Text != string.Empty;
            cb3.Visible = l3.Text != string.Empty;
         }

        public static void ShowEventType(ComboBox combobox, ComboBox cb1, ComboBox cb2, ComboBox cb3, ComboBox cb4, Label l1, Label l2, Label l3, Label l4)
        {
            ((GroupBox)combobox.Parent).Reset();

            switch ((EventType)combobox.SelectedValue.ToUInt32())
            {
                case EventType.ПО_ТАЙМЕРУ_В_БОЮ:
                case EventType.ПО_ТАЙМЕРУ_ВНЕ_БОЯ:
                    l1.Text = "Минимальное время до срабатывания (мс)";
                    l2.Text = "Максимальное время до срабатывания (мс)";
                    l3.Text = "Минимальное время до повтора (мс)";
                    l4.Text = "Максимальное время до повтора (мс)";
                    break;
                case EventType.ПРИ_ЗНАЧЕНИИ_ЖИЗНИ:
                case EventType.ПРИ_ЗНАЧЕНИИ_ЖИЗНИ_ЦЕЛИ:
                    l1.Text = "Максимальное значение жизни %";
                    l2.Text = "Минимальное значение жизни %";
                    l3.Text = "Минимальное время до повтора (мс)";
                    l4.Text = "Максимальное время до повтора (мс)";
                    break;
                case EventType.ПРИ_ЗНАЧЕНИИ_МАНЫ:
                case EventType.ПРИ_ЗНАЧЕНИИ_МАНЫ_У_ЦЕЛИ:
                    l1.Text = "Максимальное значение маны %";
                    l2.Text = "Минимальное значение маны %";
                    l3.Text = "Минимальное время до повтора (мс)";
                    l4.Text = "Максимальное время до повтора (мс)";
                    break;
                case EventType.ПРИ_УБИЙСТВЕ_ЦЕЛИ:
                case EventType.ЕСЛИ_ЦЕЛЬ_ЧИТАЕТ_ЗАКЛИНАНИЕ:
                    l1.Text = "Минимальное время до повтора (мс)";
                    l2.Text = "Максимальное время до повтора (мс)";
                    break;
                case EventType.ПРИ_УРОНЕ_ЗАКЛИНАНИЕМ:
                    l1.Text = "ID Заклинания";
                    new ButtonHandler(cb1, BType.SPELL, cb2, -1);
                    l2.Text = "Школа";
                    new ButtonHandler(cb2, typeof(School), cb1, 0);
                    l3.Text = "Минимальное время до повтора (мс)";
                    l4.Text = "Максимальное время до повтора (мс)";
                    break;
                case EventType.ПРИ_ДИСТАНЦИИ:
                    l1.Text = "Минимальная дистанция до цели";
                    l2.Text = "Максимальная дистанция до цели";
                    l3.Text = "Минимальное время до повтора (мс)";
                    l4.Text = "Максимальное время до повтора (мс)";
                    break;
                case EventType.ПРИ_ПОЯВЛЕНИИ_В_ЗОНЕ_ВИДИМОСТИ:
                    l1.Text = "Тип цели:";
                    cb1.SetEnumValues<TargetFrends>();
                    l2.Text = "Максимальная дистанция до цели";
                    l3.Text = "Минимальное время до повтора (мс)";
                    l4.Text = "Максимальное время до повтора (мс)";
                    break;
                case EventType.ПРИ_ЗНАЧЕНИИ_ЖИЗНИ_ДРУЖЕСТВЕННОЙ_ЦЕЛИ:
                    l1.Text = "Дефицит жизни дружественной цели";
                    l2.Text = "В радиусе";
                    l3.Text = "Минимальное время до повтора (мс)";
                    l4.Text = "Максимальное время до повтора (мс)";
                    break;
                case EventType.ЕСЛИ_ДРУЖЕСТВЕННАЯ_ЦЕЛЬ_ПОД_КОНТРОЛЕМ:
                    l1.Text = "Тип диспелла";
                    cb1.SetEnumValues<DispelType>("", "DISPEL_");
                    l2.Text = "В радиусе";
                    l3.Text = "Минимальное время до повтора (мс)";
                    l4.Text = "Максимальное время до повтора (мс)";
                    break;
                case EventType.ЕСЛИ_ДРУЖЕСТВЕННАЯ_ЦЕЛЬ_ТЕРЯЕТ_БАФФ:
                    l1.Text = "ID спелла (заклинания)";
                    new ButtonHandler(cb1, BType.SPELL);
                    l2.Text = "В радиусе";
                    l3.Text = "Минимальное время до повтора (мс)";
                    l4.Text = "Максимальное время до повтора (мс)";
                    break;
                case EventType.ПРИ_ВЫЗОВЕ_СУЩЕСТВА:
                    l1.Text = "ID существа";
                    new ButtonHandler(cb1, BType.CREATURE);
                    l2.Text = "Минимальное время до повтора (мс)";
                    l3.Text = "Максимальное время до повтора (мс)";
                    break;
                case EventType.ПРИ_ПОЛУЧЕНИИ_ЭМОЦИИ:
                    l1.Text = "ID эмоции";
                    l2.Text = "Условие";
                    cb1.SetDbcData(DBC.Emotes);
                    cb2.SetEnumValues<ConditionType>();
                    break;
                case EventType.ПРИ_ЗНАЧЕНИИ_АУРЫ:
                case EventType.ПРИ_ЗНАЧЕНИИ_АУРЫ_ЦЕЛИ:
                case EventType.ПРИ_ОТСУТСТВИИ_АУРЫ:
                case EventType.ПРИ_ОТСУТСТВИИ_АУРЫ_ЦЕЛИ:
                    l1.Text = "ID спелла";
                    new ButtonHandler(cb1, BType.SPELL);
                    l2.Text = "Количество";
                    l3.Text = "Минимальное время до повтора (мс)";
                    l4.Text = "Максимальное время до повтора (мс)";
                    break;
                case EventType.ПРИ_СМЕРТИ_ВЫЗВАННОГО_СУЩЕСТВА:
                case EventType.ПРИ_ИСЧЕЗНОВЕНИИ_ВЫЗВАННОГО_СУЩЕСТВА:
                    l1.Text = "ID существа";
                    new ButtonHandler(cb1, BType.CREATURE);
                    l2.Text = "Минимальное время до повтора (мс)";
                    l3.Text = "Максимальное время до повтора (мс)";
                    break;
            }

            cb1.Visible = l1.Text != string.Empty;
            cb2.Visible = l2.Text != string.Empty;
            cb3.Visible = l3.Text != string.Empty;
            cb4.Visible = l4.Text != string.Empty;
         }

        public static void ShowActionTyteCondition(ComboBox combobox, ComboBox cb2, ComboBox cb3, ComboBox cb4, Label l3, Label l4)
        {
            if ((EventType)combobox.SelectedValue.ToInt32() == EventType.ПРИ_ПОЛУЧЕНИИ_ЭМОЦИИ)
            {
                ((GroupBox)combobox.Parent).ResetButton();
                l3.Text = l4.Text = string.Empty;
                cb3.Reset();
                cb4.Reset();
                
                switch ((ConditionType)cb2.SelectedValue.ToUInt32())
                {
                    case ConditionType.ПРИ_НАЛИЧИИ_АУРЫ:
                        l3.Text = "ID спелла";
                        new ButtonHandler(cb3, BType.SPELL);
                        l4.Text = "Время до повтора (мс)";
                        break;
                    case ConditionType.ПРИ_НАЛИЧИИ_ПРЕЕДМЕТА:
                    case ConditionType.ЕСЛИ_ПРЕДМЕТ_НА_ПЕРСОНАЖЕ:
                        l3.Text = "ID предмета";
                        new ButtonHandler(cb3, BType.ITEM);
                        l4.Text = "Количество";
                        break;
                    case ConditionType.ЕСЛИ_НАХОДИТСЯ_В_ЗОНЕ:
                        l3.Text = "ID зоны";
                        cb3.SetDbcData(DBC.AreaTable);
                        break;
                    case ConditionType.ПРИ_НАЛИЧИИ_РЕПУТАЦИИ:
                        l3.Text = "ID фракции";
                        cb3.SetDbcData(DBC.Faction);
                        l4.Text = "Минимальный ранг";
                        break;
                    case ConditionType.КОМАНДА:
                        l3.Text = "Команда";
                        cb3.SetEnumValues<ConditionTeam>();
                        break;
                    case ConditionType.ПРИ_НАЛИЧИИ_УМЕНИЯ:
                        l3.Text = "ID умения";
                        cb3.SetDbcData(DBC.SkillLine);
                        l4.Text = "Минимальный уровень прокачки";
                        break;
                    case ConditionType.ЕСЛИ_КВЕСТ_СДАН:
                    case ConditionType.ЕСЛИ_КВЕСТ_НЕ_СДАН:
                        l3.Text = "ID квеста";
                        new ButtonHandler(cb3, BType.QUEST);
                        break;
                    case ConditionType.ПРИ_АКТИВНОМ_ЭВЕНТЕ:
                        l3.Text = "ID эвента";
                        cb3.SetDbcData(DBC.HolidayNames);
                        break;
                }

                cb3.Visible = l3.Text != string.Empty;
                cb4.Visible = l4.Text != string.Empty;
            }
        }
    }
}
