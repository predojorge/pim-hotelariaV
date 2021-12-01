import 'package:boilerplate_flutter/models/room.dart';
import 'package:boilerplate_flutter/modules/datails_room/details_room_content.dart';
import 'package:boilerplate_flutter/modules/datails_room/details_room_cubit.dart';
import 'package:boilerplate_flutter/modules/list_rooms/list_rooms_cubit.dart';
import 'package:flutter/material.dart';
import 'package:flutter_bloc/flutter_bloc.dart';
import 'package:get_it/get_it.dart';

import 'list_rooms_content.dart';

class ListRoomsPage extends StatelessWidget {
  static String route = '/listRooms';
  const ListRoomsPage({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Scaffold(
        appBar: AppBar(title: Text("Lista de quartos")),
        body: BlocProvider(
            create: (context) => GetIt.I.get<ListRoomsCubit>(),
            child: ListRoomsContent()));
  }
}
