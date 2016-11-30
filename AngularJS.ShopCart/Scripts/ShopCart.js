var app = angular.module('myApp', []);

app.controller('myCtrl', function ($scope) {

    //ürünler - products
    $scope.items = [
      {
          id: 1,
          name: 'iPhone 5s',
          price: 2500,
          image: ' http://localhost:4319/images/gsmarena_002.gif ',
          title: 'iPhone 5s được nâng cấp độ phân giải camera sau lên 12 MP (thay vì 8 MP như trên iPhone 5) camera có tốc độ lấy nét và chụp nhanh, thao tác chạm để chụp nhẹ nhàng. Chất lượng ảnh trong các điều kiện chụp khác nhau tốt. '
      },
      {
          id: 2,
          name: 'television',
          price: 8950,
          image: ' http://localhost:4319/images/200.gif ',
          title: 'Tiết kiệm 30% điện năng tiêu thụ so với dòng TV LCD thông thường.Góc nhìn rộng, độ tương phản tốt, dải màu rộng hơn cho hình ảnh đẹp hơn.Khả năng tản nhiệt tốt giúp tivi bền hơn.'
      },
      {
          id: 3,
          name: 'Macbook Pro',
          price: 4000,
          image: ' http://localhost:4319/images/2001.gif ',
          title: 'Macbook Air 2015 với CPU Core i5 thế hệ thứ 5 (Broadwell) của Intel, cổng Thunderbolt 2 cho tốc độ truyền tải dữ liệu nhanh hơn và bộ nhớ Flash có tốc độ nhanh hơn gấp đôi so với trước.'
      },
      {
          id: 4,
          name: 'T-shirt',
          price: 20,
          image: ' http://localhost:4319/images/2002.gif ',
          title: 'ASOS Oversized T-Shirt With Wide Kimono Sleeves And Curved Hem And Side Splits In Brown Wash'
      },
      {
          id: 5,
          name: 'Head Phone',
          price: 10,
          image: ' http://localhost:4319/images/2003.gif ',
          title: 'Head Phone for those who are passionate about C#. It aims to be a bridge between the existing introductory books and the language specification: something readable but detailed, exploring every aspect of the language from version 2 onwards. In the interests of brevity, it doesnt spend much time on C# 1 - readers are already expected to know the first version at least reasonably. Every new feature from C# 2 onwards is covered, however, as shown in the table of contents below.'
      },
      {
          id: 6,
          name: 'Notebook',
          price: 6980,
          image: ' http://localhost:4319/images/2004.gif ',
          title: 'MacBook Pro 13-inch với màn hình Retina (một trong những công nghệ màn hình tốt nhất hiện nay) với độ phân giải 2560x1600, bộ vi xử lý Core I5 thế hệ thứ 4, RAM 4 GB, ổ cứng dạng đặc SSD 128 GB và thời lượng pin có thể lên đến 9,5 giờ. Ngoài ra, MacBook Pro Retina 13-inch cũng là chiếc MacBook Pro với kích thước mỏng nhất và khối lượng nhẹ nhất từ trước đến nay của Apple, với độ dày chỉ 19mm và nặng 1,5kg.'
      }
    ];

    //sepetim - my shopping cart
    $scope.myItems = [];
    $scope.myTs=[]
    //sepete ekle - add to cart
    $scope.addItem = function (newItem) {
        if ($scope.myItems.length == 0) {
            newItem.count = 1;
            $scope.myItems.push(newItem);
        } else {
            var repeat = false;
            for (var i = 0; i < $scope.myItems.length; i++) {
                if ($scope.myItems[i].id == newItem.id) {
                    $scope.myItems[i].count++;
                    repeat = true;
                }
            }
            if (!repeat) {
                newItem.count = 1;
                $scope.myItems.push(newItem);
            }
        }
        updatePrice();
    };

    $scope.addT = function (newItem) {
        if ($scope.myTs.length == 0) {
            newItem.count = 1;
            $scope.myTs.push(newItem);
        } else {
            $scope.myTs.splice(0, $scope.myTs.length);
            newItem.count = 1;
            $scope.myTs.push(newItem);
            
        }
        
    };

   
    $scope.delete = function (item) {

        var ix =getIndeItem(item.id);
        $scope.myItems.splice(ix, 1);
        updatePrice();
    };
   
    function getIndeItem(id) {
        for (var i = 0; i < $scope.myItems.length; i++) {
            if ($scope.myItems[i].id == id ){
                return i;
            }
        }
       
    }

  
    //fiyatı güncelle (totalPrice) - update price
    var updatePrice = function () {
        var totalPrice = 0;
        for (var i = 0; i < $scope.myItems.length; i++) {
            totalPrice += ($scope.myItems[i].count) * ($scope.myItems[i].price);
        }
        $scope.totalPrice = totalPrice;
    };
    //---------
    $scope.number = function () {
       
        updatePrice();
    };
    //sepeti boşalt - empty your cart
    $scope.removeBasket = function () {
        $scope.myItems.splice(0, $scope.myItems.length);
        updatePrice();
    };

});

app.filter('reverse', function () {
    return function (items) {
        var x = items.slice().reverse();
        if (items.length > 1) {
            angular.element('#ok tr').css('background', '#fff');
            angular.element('#ok tr').filter(':first').css('background', 'lightyellow');
            setTimeout(function () {
                angular.element('#ok tr').filter(':first').css('background', '#fff');
            }, 500);
        }
        return x;
    };
});
