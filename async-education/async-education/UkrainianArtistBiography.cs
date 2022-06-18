﻿using System.Collections.Generic;

namespace async_education
{
    public class UkrainianArtistBiography
    {
        public static readonly Dictionary<string, string> Artists = new Dictionary<string, string>()
        {
            ["Malevich"] = "Казимир Северинович Малевич (пол. Kazimierz Malewicz; народився 23 лютого 1879, Київ — 15 травня 1935, УРСР, СРСР)" +
                           " — український художник-авангардист, визначний діяч українського авангарду, засновник супрематизму," +
                           " один з фундаторів кубофутуризму; педагог, теоретик мистецтва польського походження. Разом із Велимиром Хлєбниковим був членом «товариства голів земної кулі»." +
                           "Народився 11 лютого 1879 року в Києві в українсько-польскій католицькій сім'ї Северина та Людвіки Малевичів." +
                           " Раніше вважалося, що місцем народження Малевича є будинок, що не зберігся до цього часу, за адресою Бульйонська вулиця, 15." +
                           " За останніми дослідженнями, місцем народження художника був будинок його тітки Марії Оржеховської за Жилянською вулицею, нині ця територія" +
                           " — між двома житловими будинками: комплексом «Дипломат Холл» та сусідньою будівлею 1970–1980 років." +
                           " Батько був інженером цукрового виробництва, тому сім'я часто переїжджала з одного містечка до іншого, від однієї цукроварні до іншої.",
            
            ["Shevchenko"] = "Тарас Григорович Шевченко, відомий також як Кобзар (25 лютого (9 березня) 1814, с. Моринці, Київська губернія, Російська імперія (нині Звенигородський район, Черкаська область, Україна)" +
                             " — 26 лютого (10 березня) 1861, Санкт-Петербург, Російська імперія) — український письменник, класик української літератури, мислитель, художник." +
                             " Національний герой і символ України. Академік Імператорської академії мистецтв (1860). Був третьою дитиною селян-кріпаків Григорія Івановича Шевченка та Катерини Якимівни після сестри Катерини" +
                             " (8 (20) листопада 1804 — близько 1848) та брата Микити (16 (28) травня 1811 — близько 1870)." + 
                             "За родинними переказами, Тарасові діди й прадіди з батьківського боку походили від козака Андрія, який на початку XVIII століття прийшов із Запорізької Січі. Батьки його матері, Катерини Якимівни Бойко, були переселенцями з Прикарпаття.",
            
            ["Aivazovsky"] = "Іван Костянтинович Айвазовський (рос. Иван Константинович Айвазовский, вірм. Հովհաննես Այվազյան — Ованес Айвазян, 17 (29) липня 1817, Феодосія, Таврійська губернія, Російська імперія — 19 квітня (2 травня) 1900, там само) +" +
                             " — український та російський художник-мариніст і баталіст вірменського походження. Брат вірменського історика та архієпископа Вірменської апостольської церкви Габріела Айвазовського." +
                             "Окрім морської тематики працював також і в інших жанрах живопису: від анімалізму та портрету (автопортрету) до релігійного[pl] та міфологічного живопису." +
                             "Айвазовський є автором понад 6000 різних творів (картин, акварелей, малюнків тощо). Його полотна прикрашають музеї та приватні зібрання по всьому світу." +
                             " За понад шістдесят років творчої кар'єри Айвазовський брав участь у більш як 120-ти художніх виставках, понад половина з яких були персональними.",
            
            ["Marchuk"] = "Марчук Іван Степанович (нар. 12 травня 1936, с. Москалівка, тепер Кременецького району Тернопільської області, Україна) — український живописець, народний художник України," +
                          "лауреат Національної премії України ім. Шевченка. Почесний громадянин Тернополя, Києва, Канева. 2007 року потрапив до рейтингу 100 геніїв сучасності, який уклала британська газета Дейлі телеграф." +
                          "Після закінчення семирічної школи вступив до Львівського училища прикладного мистецтва імені Івана Труша на відділ декоративного розпису, де навчався протягом 1951—1956 років (викладачі Карло Звіринський, Олекса Шатківський, Н. Сукачова)." +
                          "Після служби в армії продовжував навчання на відділі кераміки Львівського інституту прикладного мистецтва, який закінчив 1965 року (викладачі Роман Сельський, Данило Довбошинський)." +
                          "У 1965—1968 роках працював у Інституті надтвердих матеріалів НАН України, у 1968—1984 роках — на Київському комбінаті монументально-декоративного мистецтва." + 
                          "У 1989—2001 роках мешкав у Австралії, Канаді й США. У 1990 році Марчук відвідав Україну й відбулася його перша офіційна виставка у Києві — у Державному художньому музеї українського образотворчого мистецтва (нині Національний художній музей України)." + 
                          "Живе та працює в Києві.",
            
            ["Yablonskaya"] = "Тетяна Нилівна Яблонська (11 (24) лютого 1917, Смоленськ, Російська імперія — 17 червня 2005, Київ, Україна) — українська художниця-живописниця, професорка (1967 рік), академік Академії мистецтв СРСР (1975), Народний художник СРСР (1982)," +
                              " дійсний член (академік) Академії мистецтв України (1997—2005), лауреатка Державних премій СРСР (1949, 1951, 1979) та Національної премії України імені Тараса Шевченка (1998), Герой України (2001). Депутат Верховної Ради УРСР 3—4-го скликань." + 
                              "Мати була викладачкою французької, батько — художником, графіком і викладачем словесності. Батьки вчили малюванню трьох своїх дітей, щороку батько влаштовував домашній художній конкурс.",
            
            ["Pimonenko"] = "Микола Корнилович Пимоненко (9 (21) березня 1862, Київ, [[Україна ]] — 26 березня (8 квітня) 1912, Київ, Російська імперія) — український художник-живописець, академік живопису Петербурзької академії мистецтв," +
                            "Член Паризької інтернаціональної спілки мистецтв і літератури, автор багатьох картин на сільську та міську тематику. З 1878 року навчався у Київській рисувальній школі. Учень відомих українських художників М. Мурашка, Й. Будкевича, Х. Платонова." +  
                            "У 1881 році склав іспит при Київському навчальному окрузі. Його екзаменаційні роботи були надіслані до Петербурзької Імператорської академії мистецтв, і за рішенням її Ради від 3 грудня 1881 року отримав звання вчителя малювання в нижчих загальноосвітніх навчальних закладах." +
                            "З 1882 року навчався в Петербурзькій академії художеств, яку через хворобу легенів та матеріальні нестатки залишив у 1884 році. Нагороджений двома малими та однією великою срібними медалями Петербурзької Академії художеств.",
        };
    }
}