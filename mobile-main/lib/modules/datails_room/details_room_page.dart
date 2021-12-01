import 'package:boilerplate_flutter/models/room.dart';
import 'package:boilerplate_flutter/modules/datails_room/details_room_content.dart';
import 'package:boilerplate_flutter/modules/datails_room/details_room_cubit.dart';
import 'package:flutter/material.dart';
import 'package:flutter_bloc/flutter_bloc.dart';
import 'package:get_it/get_it.dart';

class DetailsRoomPage extends StatelessWidget {
  static String route = '/detailsRoom';
  final RoomModel roomModel;
  const DetailsRoomPage({Key? key, required this.roomModel}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Scaffold(
        appBar: AppBar(title: Text(roomModel.title)),
        body: BlocProvider(
            create: (context) => GetIt.I.get<DetailsRoomCubit>(),
            child: DetailsRoomContent(
              roomModel: roomModel,
            )));
  }
}
