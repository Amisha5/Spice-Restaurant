use SpiceRestaurantDatabase
select * from Categories

Insert into Categories(CategoryName) values ('Appetizer')
Insert into Categories(CategoryName) values ('Dessert')
Insert into Categories(CategoryName) values ('Beverage')
Insert into Categories(CategoryName) values ('MainCourse')

select * from SubCategories

Insert into SubCategories(Category_CId,SubCategoryName) values(1,'Veg')
Insert into SubCategories(Category_CId,SubCategoryName) values(4,'Non-veg')
Insert into SubCategories(Category_CId,SubCategoryName) values(4,'veg')
Insert into SubCategories(Category_CId,SubCategoryName) values(3,'Veg')
Insert into SubCategories(Category_CId,SubCategoryName) values(2,'veg')


select * from MenuItems
truncate table MenuItems
Insert into MenuItems values('Panner Tikka','Paneer tikka is an Indian dish made from chunks of paneer marinated in spices and grilled in a tandoor.It is a vegetarian alternative to chicken tikka and other meat dishes.',500.36,4,1,
'NA')
Insert into MenuItems values('Chicken Tikka','It is traditionally small pieces of boneless chicken baked using skewers on a brazier called angeethi after marinating in Indian spices and dahi (yogurt)—essentially a boneless version of tandoori chicken.',400.36,4,2,
'Very Spicy')

Insert into MenuItems values('Gulab Jamun','It is made mainly from milk solids,
traditionally from khoya, which is milk reduced to the consistency of a soft dough.',150.77,2,1,'NA')
Insert into MenuItems values('Ice Cream','Ice cream is a very cold sweet food which is made from frozen cream or a substance like cream and has a flavour such as vanilla, chocolate, or strawberry. ',200.44,2,1,'NA')

Insert into MenuItems values('French Coffee', 'A French press (also called press pot, coffee press, coffee plunger or cafetière) is a special machine used to make coffee. It is easy to operate. ',200.06,3,1,'NA')
Insert into MenuItems values('Sprite','Sprite is a lemon-lime flavored soft drink with a crisp, clean taste that gives you the ultimate cut-through refreshment. Sprite is a lemon-lime flavored soft drink with a crisp, clean taste that gives you the ultimate cut-through refreshment.',50.36,3,1,'NA')

Insert into MenuItems values('Papdi Chaat','Papdi Chaat or Papri Chaat is a yummy snack assorted with a crunchy base of crispy poori which is topped with lip-smacking chutneys, veggies and curd',100.2,1,1,'Not_Spicy')
Insert into MenuItems values('Spring Roll','A Chinese snack consisting of a pancake filled with vegetables and sometimes meat, rolled into a cylinder and deep-fried.',200.2,1,1,'Spicy')

