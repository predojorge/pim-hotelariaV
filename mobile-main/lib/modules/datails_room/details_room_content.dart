import 'package:boilerplate_flutter/models/room.dart';
import 'package:boilerplate_flutter/shared/components/custom_snackbar.dart';
import 'package:flutter/material.dart';

class DetailsRoomContent extends StatelessWidget {
  final RoomModel roomModel;

  const DetailsRoomContent({Key? key, required this.roomModel})
      : super(key: key);

  @override
  Widget build(BuildContext context) {
    return LayoutBuilder(builder: (context, constraints) {
      return SafeArea(
          child: Stack(
        children: [
          Container(
            height: constraints.maxHeight * .6,
            decoration: BoxDecoration(
                color: Colors.white,
                image: DecorationImage(
                    fit: BoxFit.fill,
                    image: AssetImage("assets/${roomModel.asset}"))),
            child: Column(
              children: [
                Align(
                  alignment: Alignment.topRight,
                  child: Card(
                    child: ClipRRect(
                      borderRadius: BorderRadius.circular(2),
                      child: Container(
                        // height: constraints.maxHeight * .05,
                        color: Colors.white,
                        child: Padding(
                          padding: const EdgeInsets.all(8.0),
                          child: Text(roomModel.detail),
                        ),
                      ),
                    ),
                  ),
                ),
                Align(
                  alignment: Alignment.topRight,
                  child: Card(
                    child: ClipRRect(
                      borderRadius: BorderRadius.circular(2),
                      child: Container(
                        // height: constraints.maxHeight * .05,
                        color: Colors.white,
                        child: Padding(
                          padding: const EdgeInsets.all(8.0),
                          child: Text(roomModel.valor),
                        ),
                      ),
                    ),
                  ),
                ),
              ],
            ),
          ),
          Align(
            alignment: Alignment.bottomCenter,
            child: ClipRRect(
              borderRadius: BorderRadius.circular(30),
              child: Card(
                shadowColor: Colors.black,
                child: Container(
                  height: constraints.maxHeight * .5,
                  width: constraints.maxWidth * 1,
                  color: Colors.white,
                  child: Padding(
                    padding: const EdgeInsets.all(8.0),
                    child: SingleChildScrollView(
                      child: Column(children: [
                        Text(
                          roomModel.title,
                          style: TextStyle(
                              fontWeight: FontWeight.bold, fontSize: 22),
                        ),
                        SizedBox(
                          height: constraints.maxHeight * .05,
                        ),
                        Text(roomModel.description),
                        SizedBox(
                          height: constraints.maxHeight * .05,
                        ),
                        SizedBox(
                          height: constraints.maxHeight * .05,
                        ),
                        ElevatedButton(
                            onPressed: () => CustomSnackbar.show(
                                context, "Reservado com sucesso"),
                            child: Text('Reservar')),
                      ]),
                    ),
                  ),
                ),
              ),
            ),
          ),
        ],
      ));
    });
  }
}
