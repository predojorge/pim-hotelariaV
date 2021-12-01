import 'package:bloc/bloc.dart';
import 'package:equatable/equatable.dart';

part 'list_rooms_state.dart';

class ListRoomsCubit extends Cubit<ListRoomsState> {
  ListRoomsCubit() : super(ListRoomsInitial());
}
