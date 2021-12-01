import 'package:boilerplate_flutter/modules/datails_room/details_room_page.dart';
import 'package:boilerplate_flutter/modules/home/home_page.dart';
import 'package:flutter/material.dart';

class ListRoomsContent extends StatelessWidget {
  const ListRoomsContent({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return ListView.builder(
        itemCount: list.length,
        itemBuilder: (_, index) => Padding(
              padding: const EdgeInsets.all(8.0),
              child: GestureDetector(
                onTap: () => Navigator.pushNamed(context, DetailsRoomPage.route,
                    arguments: list[index]),
                child: Card(
                  shadowColor: Colors.black,
                  child: Column(
                    children: [
                      Container(
                          height: 150,
                          decoration: BoxDecoration(
                              color: Colors.white,
                              image: DecorationImage(
                                  fit: BoxFit.cover,
                                  image: AssetImage(
                                      "assets/${list[index].asset}")))),
                      Container(
                          height: 60,
                          child: Center(child: Text(list[index].title))),
                    ],
                  ),
                ),
              ),
            ));
  }
}
