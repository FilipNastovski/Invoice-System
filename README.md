# Invoice System

## 1. Опис на апликацијата
Целта на апликацијата е да им овозможи на корисниците полесно да раководат со нивниот сервис. Апликацијата ги заменува сметководителите, книговодителите и потребите за рачно запишување на податоци за секој нов клиент. Преку автоматизација на процесите, апликацијата овозможува побрз и поефикасен начин на управување со фактури и клиенти.

### Клучни карактеристики
- **Автоматско генерирање на фактури:** Креирање и испраќање на фактури без потреба од рачно внесување на податоци.
- **Следење на плаќања:** Можност за следење на статусот на плаќањата.
- **Управување со клиенти:** Едноставно управување со информации за клиентите.

### Примери од корисничкиот интерфејс

![alt text]([http://url/to/img.png](https://github.com/FilipNastovski/Invoice-System/blob/5b8a3f7f584e702f2f5b54ab4f151350aa3b37ab/Screenshots/Clients-Screenshot.png))
![alt text]([http://url/to/img.png](https://github.com/FilipNastovski/Invoice-System/blob/5b8a3f7f584e702f2f5b54ab4f151350aa3b37ab/Screenshots/Dashboard-Screenshot.png))
![alt text]([http://url/to/img.png](https://github.com/FilipNastovski/Invoice-System/blob/5b8a3f7f584e702f2f5b54ab4f151350aa3b37ab/Screenshots/InvoiceViewer-Screenshot.png))
![alt text]([http://url/to/img.png](https://github.com/FilipNastovski/Invoice-System/blob/5b8a3f7f584e702f2f5b54ab4f151350aa3b37ab/Screenshots/NewService-Screenshot.png))
![alt text]([http://url/to/img.png](https://github.com/FilipNastovski/Invoice-System/blob/5b8a3f7f584e702f2f5b54ab4f151350aa3b37ab/Screenshots/Services-Screenshot.png))
![alt text]([http://url/to/img.png](https://github.com/FilipNastovski/Invoice-System/blob/5b8a3f7f584e702f2f5b54ab4f151350aa3b37ab/Screenshots/PrintedInvoice-Screenshot.png))


## 2. Објаснување на проблемот
Многу мали бизниси имаат проблем со рачното управување со фактури и финансиски податоци. Ова е неефикасно и подложно на грешки. Традиционалното сметководство бара многу време и ресурси, што може да биде значителен товар за помалите бизниси. Апликацијата за фактурирање има за цел да ги реши овие проблеми преку автоматизација и дигитализација на процесите.

### Клучни проблеми кои ги решава апликацијата
- **Неефикасност:** Намалување на времето потребно за издавање на фактури.
- **Грешки при внесување:** Автоматизација на процесите со цел намалување на човечките грешки.
- **Следење на плаќања:** Автоматско следење и потсетување за неплатени фактури.
- **Достапност на податоци:** Сите податоци се складирани и лесно достапни во дигитален формат.

## 3. Упатство за користење
Следете ги овие чекори за да започнете со користење на апликацијата за фактурирање.

### Инсталација
1. Преземете ја апликацијата репозиториумот.
2. Стартувајте ја апликацијата преку "Invoice System.sln" или компајлирајте го кодот преку терминал.

### Основна употреба
1. **Креирање на нов клиент:**
    - Одберете ја опцијата „Креирај нов клиент“.
    - Внесете ги потребните информации за клиентот.
    - Кликнете „Зачувај“ за да го зачувате клиентот.
2. **Креирање на фактура:**
    - Изберете корисник за кој се генерира фактура.
    - Пополнете ја фактурата со соодветни податоци.
    - Проверете го форматирањето и клинкете печати.


## 4. Претставување на проблемот

### 4.1 Податочни структури
Апликацијата користи неколку податочни структури за ефикасно управување со информациите.

Класата `Customer` претставува клиент во системот за фактурирање.

### Атрибути
- `String Name`: Името на клиентот.
- `String LastName`: Презимето на клиентот.
- `List<Motorcycle> Motorcycles`: Листа на мотори кои ги поседува клиентот.
- `List<Service> ServiceHistory`: Листа на сервисни записи за моторите на клиентот.

### Конструктор
public Customer(string name, string lastName)
public Customer(string name, string lastName)
Иницијализира нов клиент со даденото име и презиме, и креира празни листи за мотори и сервисна историја.

Методи
void addMotorcycle(Motorcycle motorcycle): Додава мотор во листата на мотори на клиентот.
override string? ToString(): Враќа текстуална репрезентација на клиентот.
void GetObjectData(SerializationInfo info, StreamingContext context): Сериализира објект на клиент.
Customer(SerializationInfo info, StreamingContext context): Десериализира објект на клиент.

# Класи и Методи во Системот за Фактурирање

## Класа Customer

Класата `Customer` претставува клиент во системот за фактурирање.

### Атрибути
- `String Name`: Име на клиентот.
- `String LastName`: Презиме на клиентот.
- `List<Motorcycle> Motorcycles`: Листа на мотори кои ги поседува клиентот.
- `List<Service> ServiceHistory`: Историја на сервисирање за клиентот.

### Конструктор

public Customer(string name, string lastName)
Иницијализира нов клиент со даденото име и презиме, и креира празни листи за мотори и сервисна историја.

Класа Motorcycle
Класата Motorcycle претставува мотор во системот за фактурирање.

Методи
void addMotorcycle(Motorcycle motorcycle): Додава мотор во листата на мотори на клиентот.
override string? ToString(): Враќа текстуална репрезентација на клиентот.
void GetObjectData(SerializationInfo info, StreamingContext context): Сериализира објект на клиент.
Customer(SerializationInfo info, StreamingContext context): Десериализира објект на клиент.
Класа Motorcycle
Класата Motorcycle претставува мотор во системот за фактурирање.

Атрибути
String Model: Модел на моторот.
int Year: Година на производство на моторот.
int Kilometers: Продолжени километри на моторот.
List<Service> ServiceHistory: Историја на сервисирање за моторот.


### Врски Меѓу Класите
Customer и Motorcycle: Еден Customer може да поседува повеќе Motorcycle објекти, претставени преку атрибутот Motorcycles во класата Customer.
Motorcycle и Service: Еден Motorcycle може да има повеќе записи за Service, претставени преку атрибутот ServiceHistory во класата Motorcycle.
Service и ServiceItem: Секој Service може да вклучува повеќе ServiceItem објекти, кои се додаваат во листата ServiceItems во класата Service.
  
## 5. Лиценца
Оваа апликација е лиценцирана под GNU лиценца. Погледнете го лиценцниот фајл за повеќе информации.
