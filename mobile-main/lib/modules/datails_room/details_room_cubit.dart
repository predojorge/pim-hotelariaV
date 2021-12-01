import 'package:bloc/bloc.dart';
import 'package:equatable/equatable.dart';

part 'details_room_state.dart';

class DetailsRoomCubit extends Cubit<DetailsRoomState> {
  DetailsRoomCubit() : super(DetailsRoomInitial());
}
